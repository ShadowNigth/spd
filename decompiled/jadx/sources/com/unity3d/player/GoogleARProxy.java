package com.unity3d.player;

import android.app.Activity;
import android.content.Context;
import android.os.IBinder;
import android.util.Log;
/* JADX INFO: Access modifiers changed from: package-private */
/* loaded from: classes.dex */
public class GoogleARProxy extends C0044b {

    /* renamed from: f */
    private boolean f2f;

    /* JADX INFO: Access modifiers changed from: package-private */
    public GoogleARProxy(InterfaceC0047d interfaceC0047d) {
        super("Google AR", interfaceC0047d);
        this.f2f = false;
    }

    /* renamed from: a */
    public static boolean m148a() {
        boolean z;
        try {
            Class<?> loadClass = UnityPlayer.class.getClassLoader().loadClass("com.unity3d.unitygar.GoogleAR");
            C0061m c0061m = new C0061m(loadClass, loadClass.getConstructor(new Class[0]).newInstance(new Object[0]));
            c0061m.m30a("getClassVersion", new Class[0]);
            if (((Number) c0061m.m29a("getClassVersion", new Object[0])).intValue() > 0) {
                Log.d("Unity", "Loading ARCore V1+ path.");
                z = false;
            } else {
                Log.d("Unity", "Loading ARCore Preview path (Version <= 1).");
                z = true;
            }
            return z;
        } catch (Exception e) {
            Log.d("Unity", "Loading ARCore Preview path.");
            return true;
        }
    }

    /* renamed from: a */
    private boolean m146a(ClassLoader classLoader) {
        if (this.f2f) {
            return true;
        }
        try {
            Class<?> loadClass = classLoader.loadClass("com.unity3d.unitygar.GoogleAR");
            C0061m c0061m = new C0061m(loadClass, loadClass.getConstructor(new Class[0]).newInstance(new Object[0]));
            c0061m.m30a("initialize", new Class[]{Activity.class});
            c0061m.m30a("create", new Class[0]);
            c0061m.m30a("pause", new Class[0]);
            c0061m.m30a("resume", new Class[0]);
            this.f143a = c0061m;
            this.f2f = true;
            return true;
        } catch (Exception e) {
            this.f144b.reportError("Google AR Error", e.toString() + e.getLocalizedMessage());
            return false;
        }
    }

    private final native void tangoOnCreate(Activity activity);

    private final native void tangoOnServiceConnected(IBinder iBinder);

    private final native void tangoOnStop();

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: a */
    public final void m147a(final Activity activity, Context context) {
        if (m146a(UnityPlayer.class.getClassLoader())) {
            this.f145c = context;
            runOnUiThread(new Runnable() { // from class: com.unity3d.player.GoogleARProxy.1
                @Override // java.lang.Runnable
                public final void run() {
                    try {
                        if (GoogleARProxy.this.f143a != null) {
                            GoogleARProxy.this.f143a.m29a("initialize", activity);
                        }
                    } catch (Exception e) {
                        GoogleARProxy.this.reportError("Exception creating " + GoogleARProxy.this.f147e + " VR on UI Thread. " + e.getLocalizedMessage());
                    }
                }
            });
        }
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: b */
    public final void m145b() {
        runOnUiThread(new Runnable() { // from class: com.unity3d.player.GoogleARProxy.2
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    if (GoogleARProxy.this.f143a != null) {
                        GoogleARProxy.this.f143a.m29a("create", new Object[0]);
                    }
                } catch (Exception e) {
                    GoogleARProxy.this.reportError("Exception creating " + GoogleARProxy.this.f147e + " VR on UI Thread. " + e.getLocalizedMessage());
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: c */
    public final void m144c() {
        runOnUiThread(new Runnable() { // from class: com.unity3d.player.GoogleARProxy.3
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    if (GoogleARProxy.this.f143a != null) {
                        GoogleARProxy.this.f143a.m29a("pause", new Object[0]);
                    }
                } catch (Exception e) {
                    GoogleARProxy.this.reportError("Exception pausing " + GoogleARProxy.this.f147e + " VR on UI Thread. " + e.getLocalizedMessage());
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: d */
    public final void m143d() {
        runOnUiThread(new Runnable() { // from class: com.unity3d.player.GoogleARProxy.4
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    if (GoogleARProxy.this.f143a != null) {
                        GoogleARProxy.this.f143a.m29a("resume", new Object[0]);
                    }
                } catch (Exception e) {
                    GoogleARProxy.this.reportError("Exception resuming " + GoogleARProxy.this.f147e + " VR on UI Thread. " + e.getLocalizedMessage());
                }
            }
        });
    }

    /* renamed from: e */
    public final boolean m142e() {
        return this.f2f;
    }
}
