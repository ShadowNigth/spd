package net.codestage.actk.androidnative;

import android.util.Log;
import java.io.File;
/* JADX INFO: Access modifiers changed from: package-private */
/* loaded from: classes.dex */
public class FileFilter {
    private Boolean caseSensitive;
    private Boolean exactFileNameMatch;
    private Boolean exactFolderMatch;
    private String filterExtension;
    private String filterFileName;
    private String filterFolder;
    private Boolean folderRecursive;

    /* JADX INFO: Access modifiers changed from: package-private */
    public FileFilter(String filterString) {
        if (filterString == null || filterString.isEmpty()) {
            Log.e(NativeUtils.LogTag, "Can't parse FileFilter: string is null or empty!");
            return;
        }
        String[] items = filterString.split("\\|");
        if (items.length < 4) {
            Log.e(NativeUtils.LogTag, "Can't parse FileFilter: string split only to " + items.length + " parts instead of minimum 4 parts!");
            return;
        }
        this.caseSensitive = Boolean.valueOf(Boolean.parseBoolean(items[0]));
        this.folderRecursive = Boolean.valueOf(Boolean.parseBoolean(items[1]));
        this.exactFileNameMatch = Boolean.valueOf(Boolean.parseBoolean(items[2]));
        this.exactFolderMatch = Boolean.valueOf(Boolean.parseBoolean(items[3]));
        if (items.length >= 5) {
            this.filterFolder = items[4];
        }
        if (items.length >= 6) {
            this.filterExtension = items[5];
        }
        if (items.length >= 7) {
            this.filterFileName = items[6];
        }
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    public boolean MatchPath(String path) {
        File filePath = new File(path);
        if (this.filterExtension != null && !this.filterExtension.isEmpty()) {
            String extension = filePath.getName();
            if (extension.isEmpty() || extension.indexOf(".") <= 0) {
                return false;
            }
            int index = extension.lastIndexOf(".");
            String extension2 = extension.substring(index + 1);
            if (extension2.isEmpty()) {
                return false;
            }
            if (this.caseSensitive.booleanValue()) {
                if (!this.filterExtension.equals(extension2)) {
                    return false;
                }
            } else if (!this.filterExtension.equalsIgnoreCase(extension2)) {
                return false;
            }
        }
        if (this.filterFileName != null && !this.filterFileName.isEmpty()) {
            String fileName = filePath.getName();
            if (fileName.isEmpty()) {
                return false;
            }
            if (fileName.indexOf(".") > 0) {
                fileName = fileName.substring(0, fileName.lastIndexOf("."));
            }
            if (this.exactFileNameMatch.booleanValue()) {
                if (this.caseSensitive.booleanValue()) {
                    if (!this.filterFileName.equals(fileName)) {
                        return false;
                    }
                } else if (!this.filterFileName.equalsIgnoreCase(fileName)) {
                    return false;
                }
            } else if (this.caseSensitive.booleanValue()) {
                if (!fileName.contains(this.filterFileName)) {
                    return false;
                }
            } else if (!NativeUtils.ContainsIgnoreCase(fileName, this.filterFileName)) {
                return false;
            }
        }
        return true;
    }
}
