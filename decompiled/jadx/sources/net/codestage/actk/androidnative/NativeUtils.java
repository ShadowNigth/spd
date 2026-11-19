package net.codestage.actk.androidnative;

import android.app.Activity;
import android.content.Context;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageManager;
import android.util.Log;
import java.lang.reflect.Field;
/* loaded from: classes.dex */
class NativeUtils {
    private static Context applicationContext;
    static String LogTag = "ACTk";
    private static final char[] hexArray = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

    NativeUtils() {
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    public static String BytesToHex(byte[] bytes) {
        char[] hexChars = new char[bytes.length * 2];
        for (int j = 0; j < bytes.length; j++) {
            int v = (bytes[j] ^ 144) & 255;
            hexChars[j * 2] = hexArray[v >>> 4];
            hexChars[(j * 2) + 1] = hexArray[v & 15];
        }
        return new String(hexChars);
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    public static String GetApkPath() throws PackageManager.NameNotFoundException, IllegalAccessException, NoSuchFieldException, ClassNotFoundException {
        GetUnityPlayerActivityIfNeeded();
        if (applicationContext == null) {
            Log.e(LogTag, "[CodeHashGenerator ERROR] Couldn't get Unity context!");
            return null;
        }
        String packageName = applicationContext.getPackageName();
        if (packageName == null) {
            Log.e(LogTag, "[CodeHashGenerator ERROR] Couldn't get package name!");
            return null;
        }
        PackageManager pm = applicationContext.getPackageManager();
        if (pm == null) {
            Log.e(LogTag, "[CodeHashGenerator ERROR] Couldn't get package manager!");
            return null;
        }
        ApplicationInfo ai = pm.getApplicationInfo(packageName, 0);
        if (ai == null) {
            Log.e(LogTag, "[CodeHashGenerator ERROR] Couldn't get ApplicationInfo!");
            return null;
        }
        return ai.publicSourceDir;
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    public static boolean ContainsIgnoreCase(String str, String subString) {
        if (str == null || subString == null) {
            return false;
        }
        return str.toLowerCase().contains(subString.toLowerCase());
    }

    private static void GetUnityPlayerActivityIfNeeded() throws ClassNotFoundException, NoSuchFieldException, IllegalAccessException {
        if (applicationContext == null) {
            Class<?> unityPlayerClass = Class.forName("com.unity3d.player.UnityPlayer");
            if (unityPlayerClass == null) {
                Log.e(LogTag, "[CodeHashGenerator ERROR] Couldn't get com.unity3d.player.UnityPlayer class!");
                return;
            }
            Field field = unityPlayerClass.getDeclaredField("currentActivity");
            if (field == null) {
                Log.e(LogTag, "[CodeHashGenerator ERROR] Couldn't get com.unity3d.player.UnityPlayer:currentActivity field!");
                return;
            }
            Activity unityPlayerActivity = (Activity) field.get(null);
            if (unityPlayerActivity == null) {
                Log.e(LogTag, "[CodeHashGenerator ERROR] Couldn't get Activity from com.unity3d.player.UnityPlayer:currentActivity field!");
            } else {
                applicationContext = unityPlayerActivity.getApplicationContext();
            }
        }
    }
}
