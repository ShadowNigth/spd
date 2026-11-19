package com.unity3d.player;

import android.os.Build;
/* renamed from: com.unity3d.player.h */
/* loaded from: classes.dex */
public final class C0051h {

    /* renamed from: a */
    static final boolean f153a;

    /* renamed from: b */
    static final boolean f154b;

    /* renamed from: c */
    static final boolean f155c;

    /* renamed from: d */
    static final InterfaceC0046c f156d;

    static {
        f153a = Build.VERSION.SDK_INT >= 19;
        f154b = Build.VERSION.SDK_INT >= 21;
        boolean z = Build.VERSION.SDK_INT >= 23;
        f155c = z;
        f156d = z ? new C0049f() : null;
    }
}
