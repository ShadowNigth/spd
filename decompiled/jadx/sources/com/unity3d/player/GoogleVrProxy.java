package com.unity3d.player;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Build;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import android.view.Surface;
import android.view.SurfaceView;
import android.view.View;
import com.unity3d.player.GoogleVrVideo;
import java.lang.reflect.Array;
import java.util.Iterator;
import java.util.Vector;
import java.util.concurrent.atomic.AtomicLong;
import net.codestage.actk.androidnative.BuildConfig;
/* JADX INFO: Access modifiers changed from: package-private */
/* loaded from: classes.dex */
public class GoogleVrProxy extends C0044b implements GoogleVrVideo {

    /* renamed from: f */
    private boolean f9f;

    /* renamed from: g */
    private boolean f10g;

    /* renamed from: h */
    private Runnable f11h;

    /* renamed from: i */
    private Vector f12i;

    /* renamed from: j */
    private SurfaceView f13j;

    /* renamed from: k */
    private C0010a f14k;

    /* renamed from: l */
    private Thread f15l;

    /* renamed from: m */
    private Handler f16m;

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: com.unity3d.player.GoogleVrProxy$a */
    /* loaded from: classes.dex */
    public class C0010a {

        /* renamed from: a */
        public boolean f28a = false;

        /* renamed from: b */
        public boolean f29b = false;

        /* renamed from: c */
        public boolean f30c = false;

        /* renamed from: d */
        public boolean f31d = false;

        /* renamed from: e */
        public boolean f32e = true;

        /* renamed from: f */
        public boolean f33f = false;

        C0010a() {
        }

        /* renamed from: a */
        public final boolean m123a() {
            return this.f28a && this.f29b;
        }

        /* renamed from: b */
        public final void m122b() {
            this.f28a = false;
            this.f29b = false;
            this.f31d = false;
            this.f32e = true;
            this.f33f = false;
        }
    }

    public GoogleVrProxy(InterfaceC0047d interfaceC0047d) {
        super("Google VR", interfaceC0047d);
        this.f9f = false;
        this.f10g = false;
        this.f11h = null;
        this.f12i = new Vector();
        this.f13j = null;
        this.f14k = new C0010a();
        this.f15l = null;
        this.f16m = new Handler(Looper.getMainLooper()) { // from class: com.unity3d.player.GoogleVrProxy.1
            @Override // android.os.Handler
            public final void handleMessage(Message message) {
                switch (message.what) {
                    case 135711:
                        switch (message.arg1) {
                            case 2147483645:
                                Iterator it = GoogleVrProxy.this.f12i.iterator();
                                while (it.hasNext()) {
                                    ((GoogleVrVideo.GoogleVrVideoCallbacks) it.next()).onFrameAvailable();
                                }
                                return;
                            case 2147483646:
                                Surface surface = (Surface) message.obj;
                                Iterator it2 = GoogleVrProxy.this.f12i.iterator();
                                while (it2.hasNext()) {
                                    ((GoogleVrVideo.GoogleVrVideoCallbacks) it2.next()).onSurfaceAvailable(surface);
                                }
                                return;
                            default:
                                super.handleMessage(message);
                                return;
                        }
                    default:
                        super.handleMessage(message);
                        return;
                }
            }
        };
        initVrJni();
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: a */
    public void m131a(boolean z) {
        this.f14k.f31d = z;
    }

    /* renamed from: a */
    private static boolean m137a(int i) {
        return Build.VERSION.SDK_INT >= i;
    }

    /* renamed from: a */
    private boolean m132a(ClassLoader classLoader) {
        try {
            Class<?> loadClass = classLoader.loadClass("com.unity3d.unitygvr.GoogleVR");
            C0061m c0061m = new C0061m(loadClass, loadClass.getConstructor(new Class[0]).newInstance(new Object[0]));
            c0061m.m30a("initialize", new Class[]{Activity.class, Context.class, SurfaceView.class, Boolean.TYPE, Handler.class});
            c0061m.m30a("deinitialize", new Class[0]);
            c0061m.m30a("load", new Class[]{Boolean.TYPE, Boolean.TYPE, Boolean.TYPE, Boolean.TYPE, Boolean.TYPE, Runnable.class});
            c0061m.m30a("enable", new Class[]{Boolean.TYPE});
            c0061m.m30a("unload", new Class[0]);
            c0061m.m30a("pause", new Class[0]);
            c0061m.m30a("resume", new Class[0]);
            c0061m.m30a("getGvrLayout", new Class[0]);
            c0061m.m30a("getVideoSurfaceId", new Class[0]);
            c0061m.m30a("getVideoSurface", new Class[0]);
            this.f143a = c0061m;
            return true;
        } catch (Exception e) {
            reportError("Exception initializing GoogleVR from Unity library. " + e.getLocalizedMessage());
            return false;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: d */
    public boolean m126d() {
        return this.f14k.f31d;
    }

    /* renamed from: e */
    private void m124e() {
        Activity activity = (Activity) this.f145c;
        if (!this.f10g || this.f14k.f33f || activity == null) {
            return;
        }
        this.f14k.f33f = true;
        Intent intent = new Intent("android.intent.action.MAIN");
        intent.addCategory("android.intent.category.HOME");
        intent.setFlags(268435456);
        activity.startActivity(intent);
    }

    private final native void initVrJni();

    private final native boolean isQuiting();

    private final native void setVrVideoTransform(float[][] fArr);

    /* renamed from: a */
    public final void m135a(Intent intent) {
        if (intent == null || !intent.getBooleanExtra("android.intent.extra.VR_LAUNCH", false)) {
            return;
        }
        this.f10g = true;
    }

    /* renamed from: a */
    public final boolean m138a() {
        return this.f14k.f28a;
    }

    /* renamed from: a */
    public final boolean m136a(Activity activity, Context context, SurfaceView surfaceView, Runnable runnable) {
        boolean z;
        if (activity == null || context == null || surfaceView == null || runnable == null) {
            reportError("Invalid parameters passed to Google VR initiialization.");
            return false;
        }
        this.f14k.m122b();
        this.f145c = context;
        this.f11h = runnable;
        if (!m137a(19)) {
            reportError("Google VR requires a device that supports an api version of 19 (KitKat) or better.");
            return false;
        } else if (this.f10g && !m137a(24)) {
            reportError("Daydream requires a device that supports an api version of 24 (Nougat) or better.");
            return false;
        } else if (m132a(UnityPlayer.class.getClassLoader())) {
            try {
                z = ((Boolean) this.f143a.m29a("initialize", activity, context, surfaceView, Boolean.valueOf(this.f10g), this.f16m)).booleanValue();
            } catch (Exception e) {
                reportError("Exception while trying to intialize Unity Google VR Library. " + e.getLocalizedMessage());
                z = false;
            }
            if (!z) {
                reportError("Unable to initialize GoogleVR library.");
                return false;
            }
            this.f13j = surfaceView;
            this.f14k.f28a = true;
            this.f146d = BuildConfig.FLAVOR;
            return true;
        } else {
            return false;
        }
    }

    /* renamed from: b */
    public final void m130b() {
        resumeGvrLayout();
    }

    /* renamed from: c */
    public final void m128c() {
        if (this.f13j != null) {
            this.f13j.getHolder().setSizeFromLayout();
        }
    }

    @Override // com.unity3d.player.GoogleVrVideo
    public void deregisterGoogleVrVideoListener(GoogleVrVideo.GoogleVrVideoCallbacks googleVrVideoCallbacks) {
        if (this.f12i.contains(googleVrVideoCallbacks)) {
            googleVrVideoCallbacks.onSurfaceUnavailable();
            this.f12i.remove(googleVrVideoCallbacks);
        }
    }

    protected Object getVideoSurface() {
        if (!m126d() || this.f14k.f32e) {
            return null;
        }
        try {
            return this.f143a.m29a("getVideoSurface", new Object[0]);
        } catch (Exception e) {
            reportError("Exception caught while Getting GoogleVR Video Surface. " + e.getLocalizedMessage());
            return null;
        }
    }

    protected int getVideoSurfaceId() {
        if (!m126d() || this.f14k.f32e) {
            return -1;
        }
        try {
            return ((Integer) this.f143a.m29a("getVideoSurfaceId", new Object[0])).intValue();
        } catch (Exception e) {
            reportError("Exception caught while getting Video Surface ID from GoogleVR. " + e.getLocalizedMessage());
            return -1;
        }
    }

    protected long loadGoogleVr(final boolean z, final boolean z2, final boolean z3, final boolean z4, final boolean z5) {
        if (this.f14k.f28a) {
            final AtomicLong atomicLong = new AtomicLong(0L);
            this.f146d = (z || z2) ? "Daydream" : "Cardboard";
            if (!runOnUiThreadWithSync(new Runnable() { // from class: com.unity3d.player.GoogleVrProxy.2
                @Override // java.lang.Runnable
                public final void run() {
                    try {
                        atomicLong.set(((Long) GoogleVrProxy.this.f143a.m29a("load", Boolean.valueOf(z), Boolean.valueOf(z2), Boolean.valueOf(z3), Boolean.valueOf(z4), Boolean.valueOf(z5), GoogleVrProxy.this.f11h)).longValue());
                        GoogleVrProxy.this.f14k.f29b = true;
                    } catch (Exception e) {
                        GoogleVrProxy.this.reportError("Exception caught while loading GoogleVR. " + e.getLocalizedMessage());
                        atomicLong.set(0L);
                    }
                }
            }) || atomicLong.longValue() == 0) {
                reportError("Google VR had a fatal issue while loading. VR will not be available.");
            }
            return atomicLong.longValue();
        }
        return 0L;
    }

    /* JADX INFO: Access modifiers changed from: protected */
    public void pauseGvrLayout() {
        if (this.f14k.m123a() && !this.f14k.f32e) {
            if (m126d()) {
                Iterator it = this.f12i.iterator();
                while (it.hasNext()) {
                    ((GoogleVrVideo.GoogleVrVideoCallbacks) it.next()).onSurfaceUnavailable();
                }
            }
            if (this.f143a != null) {
                this.f143a.m29a("pause", new Object[0]);
            }
            this.f14k.f32e = true;
        }
    }

    @Override // com.unity3d.player.GoogleVrVideo
    public void registerGoogleVrVideoListener(GoogleVrVideo.GoogleVrVideoCallbacks googleVrVideoCallbacks) {
        if (this.f12i.contains(googleVrVideoCallbacks)) {
            return;
        }
        this.f12i.add(googleVrVideoCallbacks);
        Surface surface = (Surface) getVideoSurface();
        if (surface != null) {
            googleVrVideoCallbacks.onSurfaceAvailable(surface);
        }
    }

    protected void resumeGvrLayout() {
        if (this.f14k.m123a() && this.f14k.f32e) {
            if (this.f143a != null) {
                this.f143a.m29a("resume", new Object[0]);
            }
            this.f14k.f32e = false;
        }
    }

    protected void setGoogleVrModeEnabled(final boolean z) {
        if (!this.f14k.m123a() || this.f144b == null || this.f145c == null) {
            return;
        }
        if (!z && isQuiting()) {
            m124e();
        }
        runOnUiThread(new Runnable() { // from class: com.unity3d.player.GoogleVrProxy.3
            @Override // java.lang.Runnable
            public final void run() {
                if (z == GoogleVrProxy.this.m126d()) {
                    return;
                }
                try {
                    if (z && !GoogleVrProxy.this.m126d()) {
                        if (GoogleVrProxy.this.f143a != null && GoogleVrProxy.this.f144b != null && !GoogleVrProxy.this.f144b.addViewToPlayer((View) GoogleVrProxy.this.f143a.m29a("getGvrLayout", new Object[0]), true)) {
                            GoogleVrProxy.this.reportError("Unable to add Google VR to view hierarchy.");
                            return;
                        }
                        if (GoogleVrProxy.this.f143a != null) {
                            GoogleVrProxy.this.f143a.m29a("enable", true);
                        }
                        GoogleVrProxy.this.m131a(true);
                    } else if (z || !GoogleVrProxy.this.m126d()) {
                    } else {
                        GoogleVrProxy.this.m131a(false);
                        if (GoogleVrProxy.this.f143a != null) {
                            GoogleVrProxy.this.f143a.m29a("enable", false);
                        }
                        if (GoogleVrProxy.this.f143a == null || GoogleVrProxy.this.f144b == null) {
                            return;
                        }
                        GoogleVrProxy.this.f144b.removeViewFromPlayer((View) GoogleVrProxy.this.f143a.m29a("getGvrLayout", new Object[0]));
                    }
                } catch (Exception e) {
                    GoogleVrProxy.this.reportError("Exception enabling Google VR on UI Thread. " + e.getLocalizedMessage());
                }
            }
        });
    }

    @Override // com.unity3d.player.GoogleVrVideo
    public void setVideoLocationTransform(float[] fArr) {
        float[][] fArr2 = (float[][]) Array.newInstance(Float.TYPE, 4, 4);
        for (int i = 0; i < 4; i++) {
            for (int i2 = 0; i2 < 4; i2++) {
                fArr2[i][i2] = fArr[(i * 4) + i2];
            }
        }
        setVrVideoTransform(fArr2);
    }

    protected void unloadGoogleVr() {
        if (this.f14k.f31d) {
            setGoogleVrModeEnabled(false);
        }
        if (this.f14k.f30c) {
            this.f14k.f30c = false;
        }
        this.f13j = null;
        runOnUiThread(new Runnable() { // from class: com.unity3d.player.GoogleVrProxy.4
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    if (GoogleVrProxy.this.f143a != null) {
                        GoogleVrProxy.this.f143a.m29a("unload", new Object[0]);
                        GoogleVrProxy.this.f143a.m29a("deinitialize", new Object[0]);
                        GoogleVrProxy.this.f143a = null;
                    }
                    GoogleVrProxy.this.f14k.f29b = false;
                } catch (Exception e) {
                    GoogleVrProxy.this.reportError("Exception unloading Google VR on UI Thread. " + e.getLocalizedMessage());
                }
            }
        });
    }
}
