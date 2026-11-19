package com.unity3d.player;
/* JADX INFO: Access modifiers changed from: package-private */
/* renamed from: com.unity3d.player.l */
/* loaded from: classes.dex */
public final class C0060l {

    /* renamed from: a */
    private static boolean f176a = false;

    /* renamed from: b */
    private boolean f177b;

    /* renamed from: c */
    private boolean f178c;

    /* renamed from: d */
    private boolean f179d;

    /* renamed from: e */
    private boolean f180e;

    /* JADX INFO: Access modifiers changed from: package-private */
    public C0060l() {
        this.f177b = !C0051h.f155c;
        this.f178c = false;
        this.f179d = false;
        this.f180e = true;
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: a */
    public static void m41a() {
        f176a = true;
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: b */
    public static void m39b() {
        f176a = false;
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: c */
    public static boolean m37c() {
        return f176a;
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: a */
    public final void m40a(boolean z) {
        this.f178c = z;
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: b */
    public final void m38b(boolean z) {
        this.f180e = z;
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: c */
    public final void m36c(boolean z) {
        this.f179d = z;
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: d */
    public final void m35d() {
        this.f177b = true;
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: e */
    public final boolean m34e() {
        return this.f180e;
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: f */
    public final boolean m33f() {
        return f176a && this.f178c && this.f177b && !this.f180e && !this.f179d;
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: g */
    public final boolean m32g() {
        return this.f179d;
    }

    public final String toString() {
        return super.toString();
    }
}
