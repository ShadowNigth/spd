package com.unity3d.player;

import android.app.Activity;
import android.app.FragmentTransaction;
import android.content.pm.ActivityInfo;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageInfo;
import android.content.pm.PackageItemInfo;
import android.content.pm.PackageManager;
import android.os.Bundle;
import java.util.LinkedList;
/* renamed from: com.unity3d.player.f */
/* loaded from: classes.dex */
public final class C0049f implements InterfaceC0046c {
    /* renamed from: a */
    private static boolean m52a(PackageItemInfo packageItemInfo) {
        try {
            return packageItemInfo.metaData.getBoolean("unityplayer.SkipPermissionsDialog");
        } catch (Exception e) {
            return false;
        }
    }

    @Override // com.unity3d.player.InterfaceC0046c
    /* renamed from: a */
    public final void mo53a(Activity activity, Runnable runnable) {
        String[] strArr;
        if (activity == null) {
            return;
        }
        PackageManager packageManager = activity.getPackageManager();
        try {
            ActivityInfo activityInfo = packageManager.getActivityInfo(activity.getComponentName(), 128);
            ApplicationInfo applicationInfo = packageManager.getApplicationInfo(activity.getPackageName(), 128);
            if (m52a(activityInfo) || m52a(applicationInfo)) {
                runnable.run();
                return;
            }
        } catch (Exception e) {
        }
        try {
            PackageInfo packageInfo = packageManager.getPackageInfo(activity.getPackageName(), 4096);
            if (packageInfo.requestedPermissions == null) {
                packageInfo.requestedPermissions = new String[0];
            }
            LinkedList linkedList = new LinkedList();
            for (String str : packageInfo.requestedPermissions) {
                try {
                    if ((packageManager.getPermissionInfo(str, 128).protectionLevel & 1) != 0 && activity.checkCallingOrSelfPermission(str) != 0) {
                        linkedList.add(str);
                    }
                } catch (PackageManager.NameNotFoundException e2) {
                    C0048e.Log(5, "Failed to get permission info for " + str + ", manifest likely missing custom permission declaration");
                    C0048e.Log(5, "Permission " + str + " ignored");
                }
            }
            if (linkedList.isEmpty()) {
                runnable.run();
                return;
            }
            FragmentC0050g fragmentC0050g = new FragmentC0050g(runnable);
            Bundle bundle = new Bundle();
            bundle.putStringArray("PermissionNames", (String[]) linkedList.toArray(new String[0]));
            fragmentC0050g.setArguments(bundle);
            FragmentTransaction beginTransaction = activity.getFragmentManager().beginTransaction();
            beginTransaction.add(0, fragmentC0050g);
            beginTransaction.commit();
        } catch (Exception e3) {
            C0048e.Log(6, "Unable to query for permission: " + e3.getMessage());
        }
    }
}
