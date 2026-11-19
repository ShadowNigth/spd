package com.unity3d.player;

import java.util.concurrent.atomic.AtomicReference;
/* loaded from: classes.dex */
public class GoogleVrApi {

    /* renamed from: a */
    private static AtomicReference f8a = new AtomicReference();

    private GoogleVrApi() {
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: a */
    public static void m141a() {
        f8a.set(null);
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: a */
    public static void m140a(InterfaceC0047d interfaceC0047d) {
        f8a.compareAndSet(null, new GoogleVrProxy(interfaceC0047d));
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: b */
    public static GoogleVrProxy m139b() {
        return (GoogleVrProxy) f8a.get();
    }

    public static GoogleVrVideo getGoogleVrVideo() {
        return (GoogleVrVideo) f8a.get();
    }
}
