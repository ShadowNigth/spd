package com.unity3d.player;

import android.util.Log;
/* renamed from: com.unity3d.player.e */
/* loaded from: classes.dex */
final class C0048e {

    /* renamed from: a */
    protected static boolean f151a = false;

    /* JADX INFO: Access modifiers changed from: protected */
    public static void Log(int i, String str) {
        if (f151a) {
            return;
        }
        if (i == 6) {
            Log.e("Unity", str);
        }
        if (i == 5) {
            Log.w("Unity", str);
        }
    }
}
