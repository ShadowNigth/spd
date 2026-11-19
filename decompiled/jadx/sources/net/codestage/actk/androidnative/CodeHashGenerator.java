package net.codestage.actk.androidnative;

import android.content.pm.PackageManager;
import android.os.AsyncTask;
import android.text.TextUtils;
import android.util.Log;
import java.io.File;
import java.io.IOException;
import java.io.InputStream;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Enumeration;
import java.util.Iterator;
import java.util.List;
import java.util.jar.JarEntry;
import java.util.jar.JarFile;
/* loaded from: classes.dex */
public class CodeHashGenerator {
    private static CodeHashCallback lastCallback;

    /* JADX INFO: Access modifiers changed from: private */
    /* loaded from: classes.dex */
    public static class HashCalculationResult {
        String buildPath;
        String errorText;
        String[] hashes;
        String[] paths;
        String summaryHash;

        private HashCalculationResult() {
        }
    }

    /* loaded from: classes.dex */
    private static class CodeHashCalculator extends AsyncTask<String[], Void, HashCalculationResult> {
        private CodeHashCalculator() {
        }

        /* JADX INFO: Access modifiers changed from: protected */
        @Override // android.os.AsyncTask
        public HashCalculationResult doInBackground(String[]... params) {
            try {
                FileFilter[] filters = CodeHashGenerator.GetFiltersFromStrings(params[0]);
                return CodeHashGenerator.GetCodeHashThread(filters);
            } catch (Throwable x) {
                HashCalculationResult result = new HashCalculationResult();
                result.errorText = ACTkErrors.GetText("Something went wrong while trying to hash current APK: " + x.toString());
                Log.e(NativeUtils.LogTag, result.errorText, x);
                return result;
            }
        }

        /* JADX INFO: Access modifiers changed from: protected */
        @Override // android.os.AsyncTask
        public void onPostExecute(HashCalculationResult result) {
            if (result.errorText != null) {
                CodeHashGenerator.lastCallback.OnError(result.errorText);
            } else {
                CodeHashGenerator.lastCallback.OnSuccess(result.buildPath, result.paths, result.hashes, result.summaryHash);
            }
        }
    }

    public static void GetCodeHash(String[] fileFilters, CodeHashCallback callback) {
        lastCallback = callback;
        new CodeHashCalculator().execute(fileFilters);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static HashCalculationResult GetCodeHashThread(FileFilter[] fileFilters) throws ClassNotFoundException, PackageManager.NameNotFoundException, NoSuchFieldException, IllegalAccessException, IOException, NoSuchAlgorithmException {
        HashCalculationResult result = new HashCalculationResult();
        String currentApkPath = NativeUtils.GetApkPath();
        if (currentApkPath == null) {
            result.errorText = "[CodeHashGenerator ERROR] Can't get APK path!";
            Log.e(NativeUtils.LogTag, result.errorText);
        } else {
            List<String> apkFiles = new ArrayList<>();
            File apkFile = new File(currentApkPath);
            if (!apkFile.exists()) {
                result.errorText = ACTkErrors.GetText("[CodeHashGenerator ERROR] Can't create file for APK path: " + currentApkPath);
                Log.e(NativeUtils.LogTag, result.errorText);
            } else {
                File apkFolder = apkFile.getParentFile();
                if (apkFolder == null) {
                    Log.w(NativeUtils.LogTag, "[CodeHashGenerator ERROR] Can't find parent folder of APK file at path: ");
                    apkFiles.add(currentApkPath);
                    result.buildPath = currentApkPath;
                } else {
                    File[] filesInApkFolder = apkFolder.listFiles();
                    if (filesInApkFolder == null || filesInApkFolder.length == 0) {
                        Log.w(NativeUtils.LogTag, "[CodeHashGenerator ERROR] Can't get any files in APK folder at path: ");
                        apkFiles.add(currentApkPath);
                        result.buildPath = currentApkPath;
                    } else {
                        for (File file : filesInApkFolder) {
                            String apkPath = file.getPath();
                            if (apkPath.equals(BuildConfig.FLAVOR)) {
                                Log.w(NativeUtils.LogTag, "[CodeHashGenerator ERROR] Can't get path for file in APK folder!");
                            } else if (apkPath.toLowerCase().endsWith(".apk")) {
                                apkFiles.add(apkPath);
                            }
                        }
                        result.buildPath = currentApkPath;
                    }
                }
                MessageDigest digest = MessageDigest.getInstance("SHA-1");
                if (digest == null) {
                    result.errorText = ACTkErrors.GetText("[CodeHashGenerator ERROR] Can't get SHA-1 digest instance!");
                    Log.e(NativeUtils.LogTag, result.errorText);
                } else {
                    List<String> paths = new ArrayList<>();
                    List<String> hashes = new ArrayList<>();
                    Iterator<String> it = apkFiles.iterator();
                    while (true) {
                        if (it.hasNext()) {
                            String apkPath2 = it.next();
                            JarFile jar = GetJarFromApk(apkPath2);
                            if (jar == null) {
                                result.errorText = ACTkErrors.GetText("[CodeHashGenerator ERROR] Can't read APK with path: " + apkPath2);
                                Log.e(NativeUtils.LogTag, result.errorText);
                                break;
                            }
                            HashFiles(digest, jar, fileFilters, paths, hashes);
                        } else if (hashes.size() == 0) {
                            result.errorText = ACTkErrors.GetText("[CodeHashGenerator ERROR] Nothing to hash!");
                            Log.e(NativeUtils.LogTag, result.errorText);
                        } else {
                            result.buildPath = currentApkPath;
                            result.hashes = (String[]) hashes.toArray(new String[0]);
                            result.paths = (String[]) paths.toArray(new String[0]);
                            result.summaryHash = GetArrayHash(digest, hashes);
                        }
                    }
                }
            }
        }
        return result;
    }

    private static JarFile GetJarFromApk(String apkPath) throws IOException {
        File apkFile = new File(apkPath);
        if (apkFile.exists()) {
            return new JarFile(apkPath);
        }
        return null;
    }

    private static void HashFiles(MessageDigest digest, JarFile jar, FileFilter[] fileFilters, List<String> paths, List<String> hashes) throws IOException {
        byte[] buffer = new byte[8192];
        Enumeration<JarEntry> entries = jar.entries();
        if (entries == null) {
            Log.e(NativeUtils.LogTag, "[CodeHashGenerator ERROR] Nothing found in APK JAR!");
            return;
        }
        List<JarEntry> entriesList = Collections.list(entries);
        for (JarEntry entry : entriesList) {
            if (entry == null) {
                Log.w(NativeUtils.LogTag, "[CodeHashGenerator ERROR] Some JAR entry is null!");
            } else {
                String entryPath = entry.getName();
                if (entryPath == null) {
                    Log.w(NativeUtils.LogTag, "[CodeHashGenerator ERROR] Some JAR entry has null path!");
                } else {
                    boolean suitableFile = false;
                    int length = fileFilters.length;
                    int i = 0;
                    while (true) {
                        if (i >= length) {
                            break;
                        }
                        FileFilter fileFilter = fileFilters[i];
                        if (!fileFilter.MatchPath(entryPath)) {
                            i++;
                        } else {
                            suitableFile = true;
                            break;
                        }
                    }
                    if (suitableFile) {
                        InputStream is = jar.getInputStream(entry);
                        if (is == null) {
                            Log.w(NativeUtils.LogTag, "[CodeHashGenerator ERROR] JAR has null input stream for entry with path: " + entryPath);
                        } else {
                            int n = 0;
                            while (n != -1) {
                                n = is.read(buffer);
                                if (n > 0) {
                                    digest.update(buffer, 0, n);
                                }
                            }
                            byte[] fileDigest = digest.digest();
                            String digestString = NativeUtils.BytesToHex(fileDigest);
                            paths.add(entryPath);
                            hashes.add(digestString);
                            digest.reset();
                            is.close();
                        }
                    }
                }
            }
        }
    }

    private static String GetArrayHash(MessageDigest digest, List<String> hashes) {
        Collections.sort(hashes);
        String allHashes = TextUtils.join(BuildConfig.FLAVOR, hashes);
        byte[] allHashesBytes = allHashes.getBytes();
        digest.update(allHashesBytes);
        byte[] hashBytes = digest.digest();
        return NativeUtils.BytesToHex(hashBytes);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static FileFilter[] GetFiltersFromStrings(String[] strings) {
        FileFilter[] result = new FileFilter[strings.length];
        for (int i = 0; i < strings.length; i++) {
            String filterString = strings[i];
            result[i] = new FileFilter(filterString);
        }
        return result;
    }
}
