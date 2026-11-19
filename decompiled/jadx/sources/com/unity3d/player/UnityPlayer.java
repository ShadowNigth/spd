package com.unity3d.player;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.pm.ApplicationInfo;
import android.content.res.Configuration;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import android.os.MessageQueue;
import android.os.Process;
import android.telephony.PhoneStateListener;
import android.telephony.TelephonyManager;
import android.view.InputEvent;
import android.view.KeyEvent;
import android.view.MotionEvent;
import android.view.Surface;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewParent;
import android.widget.FrameLayout;
import com.unity3d.player.C0056j;
import com.unity3d.player.C0066o;
import java.io.UnsupportedEncodingException;
import java.util.concurrent.ConcurrentLinkedQueue;
import java.util.concurrent.Semaphore;
import java.util.concurrent.TimeUnit;
/* loaded from: classes.dex */
public class UnityPlayer extends FrameLayout implements InterfaceC0047d {
    public static Activity currentActivity = null;

    /* renamed from: r */
    private static boolean f45r;

    /* renamed from: a */
    C0038e f46a;

    /* renamed from: b */
    DialogC0052i f47b;

    /* renamed from: c */
    private int f48c;

    /* renamed from: d */
    private boolean f49d;

    /* renamed from: e */
    private boolean f50e;

    /* renamed from: f */
    private C0060l f51f;

    /* renamed from: g */
    private final ConcurrentLinkedQueue f52g;

    /* renamed from: h */
    private BroadcastReceiver f53h;

    /* renamed from: i */
    private boolean f54i;

    /* renamed from: j */
    private C0036c f55j;

    /* renamed from: k */
    private TelephonyManager f56k;

    /* renamed from: l */
    private C0056j f57l;

    /* renamed from: m */
    private GoogleARProxy f58m;

    /* renamed from: n */
    private GoogleARCoreApi f59n;

    /* renamed from: o */
    private C0034a f60o;

    /* renamed from: p */
    private Context f61p;

    /* renamed from: q */
    private SurfaceView f62q;

    /* renamed from: s */
    private boolean f63s;

    /* renamed from: t */
    private C0066o f64t;

    /* renamed from: com.unity3d.player.UnityPlayer$3 */
    /* loaded from: classes.dex */
    class C00273 extends BroadcastReceiver {

        /* renamed from: a */
        final /* synthetic */ UnityPlayer f87a;

        @Override // android.content.BroadcastReceiver
        public void onReceive(Context context, Intent intent) {
            this.f87a.m94c();
        }
    }

    /* renamed from: com.unity3d.player.UnityPlayer$a */
    /* loaded from: classes.dex */
    class C0034a implements SensorEventListener {
        C0034a() {
        }

        @Override // android.hardware.SensorEventListener
        public final void onAccuracyChanged(Sensor sensor, int i) {
        }

        @Override // android.hardware.SensorEventListener
        public final void onSensorChanged(SensorEvent sensorEvent) {
        }
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* JADX WARN: $VALUES field not found */
    /* JADX WARN: Failed to restore enum class, 'enum' modifier and super class removed */
    /* renamed from: com.unity3d.player.UnityPlayer$b */
    /* loaded from: classes.dex */
    public static final class EnumC0035b {

        /* renamed from: a */
        public static final int f108a = 1;

        /* renamed from: b */
        public static final int f109b = 2;

        /* renamed from: c */
        public static final int f110c = 3;

        /* renamed from: d */
        private static final /* synthetic */ int[] f111d = {f108a, f109b, f110c};
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: com.unity3d.player.UnityPlayer$c */
    /* loaded from: classes.dex */
    public class C0036c extends PhoneStateListener {
        private C0036c() {
        }

        /* synthetic */ C0036c(UnityPlayer unityPlayer, byte b) {
            this();
        }

        @Override // android.telephony.PhoneStateListener
        public final void onCallStateChanged(int i, String str) {
            UnityPlayer.this.nativeMuteMasterAudio(i == 1);
        }
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: com.unity3d.player.UnityPlayer$d */
    /* loaded from: classes.dex */
    public enum EnumC0037d {
        PAUSE,
        RESUME,
        QUIT,
        SURFACE_LOST,
        SURFACE_ACQUIRED,
        FOCUS_LOST,
        FOCUS_GAINED,
        NEXT_FRAME
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: com.unity3d.player.UnityPlayer$e */
    /* loaded from: classes.dex */
    public class C0038e extends Thread {

        /* renamed from: a */
        Handler f122a;

        /* renamed from: b */
        boolean f123b;

        /* renamed from: c */
        boolean f124c;

        /* renamed from: d */
        int f125d;

        /* renamed from: e */
        int f126e;

        private C0038e() {
            this.f123b = false;
            this.f124c = false;
            this.f125d = EnumC0035b.f109b;
            this.f126e = 5;
        }

        /* synthetic */ C0038e(UnityPlayer unityPlayer, byte b) {
            this();
        }

        /* renamed from: a */
        private void m64a(EnumC0037d enumC0037d) {
            if (this.f122a != null) {
                Message.obtain(this.f122a, 2269, enumC0037d).sendToTarget();
            }
        }

        /* renamed from: a */
        public final void m65a() {
            m64a(EnumC0037d.QUIT);
        }

        /* renamed from: a */
        public final void m63a(Runnable runnable) {
            if (this.f122a == null) {
                return;
            }
            m64a(EnumC0037d.PAUSE);
            Message.obtain(this.f122a, runnable).sendToTarget();
        }

        /* renamed from: b */
        public final void m62b() {
            m64a(EnumC0037d.RESUME);
        }

        /* renamed from: b */
        public final void m61b(Runnable runnable) {
            if (this.f122a == null) {
                return;
            }
            m64a(EnumC0037d.SURFACE_LOST);
            Message.obtain(this.f122a, runnable).sendToTarget();
        }

        /* renamed from: c */
        public final void m60c() {
            m64a(EnumC0037d.FOCUS_GAINED);
        }

        /* renamed from: c */
        public final void m59c(Runnable runnable) {
            if (this.f122a == null) {
                return;
            }
            Message.obtain(this.f122a, runnable).sendToTarget();
            m64a(EnumC0037d.SURFACE_ACQUIRED);
        }

        /* renamed from: d */
        public final void m58d() {
            m64a(EnumC0037d.FOCUS_LOST);
        }

        @Override // java.lang.Thread, java.lang.Runnable
        public final void run() {
            setName("UnityMain");
            Looper.prepare();
            this.f122a = new Handler(new Handler.Callback() { // from class: com.unity3d.player.UnityPlayer.e.1
                /* renamed from: a */
                private void m57a() {
                    if (C0038e.this.f125d == EnumC0035b.f110c && C0038e.this.f124c) {
                        UnityPlayer.this.nativeFocusChanged(true);
                        C0038e.this.f125d = EnumC0035b.f108a;
                    }
                }

                @Override // android.os.Handler.Callback
                public final boolean handleMessage(Message message) {
                    if (message.what != 2269) {
                        return false;
                    }
                    EnumC0037d enumC0037d = (EnumC0037d) message.obj;
                    if (enumC0037d == EnumC0037d.NEXT_FRAME) {
                        return true;
                    }
                    if (enumC0037d == EnumC0037d.QUIT) {
                        Looper.myLooper().quit();
                    } else if (enumC0037d == EnumC0037d.RESUME) {
                        C0038e.this.f123b = true;
                    } else if (enumC0037d == EnumC0037d.PAUSE) {
                        C0038e.this.f123b = false;
                    } else if (enumC0037d == EnumC0037d.SURFACE_LOST) {
                        C0038e.this.f124c = false;
                    } else if (enumC0037d == EnumC0037d.SURFACE_ACQUIRED) {
                        C0038e.this.f124c = true;
                        m57a();
                    } else if (enumC0037d == EnumC0037d.FOCUS_LOST) {
                        if (C0038e.this.f125d == EnumC0035b.f108a) {
                            UnityPlayer.this.nativeFocusChanged(false);
                        }
                        C0038e.this.f125d = EnumC0035b.f109b;
                    } else if (enumC0037d == EnumC0037d.FOCUS_GAINED) {
                        C0038e.this.f125d = EnumC0035b.f110c;
                        m57a();
                    }
                    return true;
                }
            });
            Looper.myQueue().addIdleHandler(new MessageQueue.IdleHandler() { // from class: com.unity3d.player.UnityPlayer.e.2
                @Override // android.os.MessageQueue.IdleHandler
                public final boolean queueIdle() {
                    UnityPlayer.this.executeGLThreadJobs();
                    if (C0038e.this.f123b && C0038e.this.f124c) {
                        if (C0038e.this.f126e >= 0) {
                            if (C0038e.this.f126e == 0 && UnityPlayer.this.m82i()) {
                                UnityPlayer.this.m112a();
                            }
                            C0038e c0038e = C0038e.this;
                            c0038e.f126e--;
                        }
                        if (!UnityPlayer.this.isFinishing() && !UnityPlayer.this.nativeRender()) {
                            UnityPlayer.this.m94c();
                        }
                        Message.obtain(C0038e.this.f122a, 2269, EnumC0037d.NEXT_FRAME).sendToTarget();
                    }
                    return true;
                }
            });
            Looper.loop();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: com.unity3d.player.UnityPlayer$f */
    /* loaded from: classes.dex */
    public abstract class AbstractRunnableC0041f implements Runnable {
        private AbstractRunnableC0041f() {
        }

        /* synthetic */ AbstractRunnableC0041f(UnityPlayer unityPlayer, byte b) {
            this();
        }

        /* renamed from: a */
        public abstract void mo56a();

        @Override // java.lang.Runnable
        public final void run() {
            if (UnityPlayer.this.isFinishing()) {
                return;
            }
            mo56a();
        }
    }

    static {
        new C0059k().m42a();
        f45r = false;
        f45r = loadLibraryStatic("main");
    }

    public UnityPlayer(Context context) {
        super(context);
        this.f48c = -1;
        this.f49d = false;
        this.f50e = true;
        this.f51f = new C0060l();
        this.f52g = new ConcurrentLinkedQueue();
        this.f53h = null;
        this.f46a = new C0038e(this, (byte) 0);
        this.f54i = false;
        this.f55j = new C0036c(this, (byte) 0);
        this.f58m = null;
        this.f59n = null;
        this.f60o = new C0034a();
        this.f47b = null;
        if (context instanceof Activity) {
            currentActivity = (Activity) context;
            this.f48c = currentActivity.getRequestedOrientation();
        }
        m110a(currentActivity);
        this.f61p = context;
        if (currentActivity != null && m82i()) {
            this.f57l = new C0056j(this.f61p, C0056j.EnumC0058a.m43a()[getSplashMode()]);
            addView(this.f57l);
        }
        if (C0051h.f155c) {
            if (currentActivity != null) {
                C0051h.f156d.mo53a(currentActivity, new Runnable() { // from class: com.unity3d.player.UnityPlayer.1
                    @Override // java.lang.Runnable
                    public final void run() {
                        UnityPlayer.this.m100a(new Runnable() { // from class: com.unity3d.player.UnityPlayer.1.1
                            @Override // java.lang.Runnable
                            public final void run() {
                                UnityPlayer.this.f51f.m35d();
                                UnityPlayer.this.m88f();
                            }
                        });
                    }
                });
            } else {
                this.f51f.m35d();
            }
        }
        m108a(this.f61p.getApplicationInfo());
        if (!C0060l.m37c()) {
            AlertDialog create = new AlertDialog.Builder(this.f61p).setTitle("Failure to initialize!").setPositiveButton("OK", new DialogInterface.OnClickListener() { // from class: com.unity3d.player.UnityPlayer.13
                @Override // android.content.DialogInterface.OnClickListener
                public final void onClick(DialogInterface dialogInterface, int i) {
                    UnityPlayer.this.m94c();
                }
            }).setMessage("Your hardware does not support this application, sorry!").create();
            create.setCancelable(false);
            create.show();
            return;
        }
        initJni(context);
        this.f62q = m99b();
        this.f62q.setContentDescription(m109a(context));
        addView(this.f62q);
        bringChildToFront(this.f57l);
        this.f63s = false;
        nativeInitWebRequest(UnityWebRequest.class);
        m78k();
        this.f56k = (TelephonyManager) this.f61p.getSystemService("phone");
        this.f46a.start();
    }

    public static void UnitySendMessage(String str, String str2, String str3) {
        if (!C0060l.m37c()) {
            C0048e.Log(5, "Native libraries not loaded - dropping message for " + str + "." + str2);
            return;
        }
        try {
            nativeUnitySendMessage(str, str2, str3.getBytes("UTF-8"));
        } catch (UnsupportedEncodingException e) {
        }
    }

    /* renamed from: a */
    private static String m109a(Context context) {
        return context.getResources().getString(context.getResources().getIdentifier("game_view_content_description", "string", context.getPackageName()));
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: a */
    public void m112a() {
        m100a(new Runnable() { // from class: com.unity3d.player.UnityPlayer.15
            @Override // java.lang.Runnable
            public final void run() {
                UnityPlayer.this.removeView(UnityPlayer.this.f57l);
                UnityPlayer.m83h(UnityPlayer.this);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: a */
    public void m111a(int i, Surface surface) {
        if (this.f49d) {
            return;
        }
        m98b(0, surface);
    }

    /* renamed from: a */
    private static void m110a(Activity activity) {
        View decorView;
        if (activity == null || !activity.getIntent().getBooleanExtra("android.intent.extra.VR_LAUNCH", false) || activity.getWindow() == null || (decorView = activity.getWindow().getDecorView()) == null) {
            return;
        }
        decorView.setSystemUiVisibility(7);
    }

    /* renamed from: a */
    private static void m108a(ApplicationInfo applicationInfo) {
        if (f45r && NativeLoader.load(applicationInfo.nativeLibraryDir)) {
            C0060l.m41a();
        }
    }

    /* renamed from: a */
    private void m107a(View view, View view2) {
        boolean z;
        if (this.f51f.m34e()) {
            z = false;
        } else {
            pause();
            z = true;
        }
        if (view != null) {
            ViewParent parent = view.getParent();
            if (!(parent instanceof UnityPlayer) || ((UnityPlayer) parent) != this) {
                if (parent instanceof ViewGroup) {
                    ((ViewGroup) parent).removeView(view);
                }
                addView(view);
                bringChildToFront(view);
                view.setVisibility(0);
            }
        }
        if (view2 != null && view2.getParent() == this) {
            view2.setVisibility(8);
            removeView(view2);
        }
        if (z) {
            resume();
        }
    }

    /* renamed from: a */
    private void m106a(AbstractRunnableC0041f abstractRunnableC0041f) {
        if (isFinishing()) {
            return;
        }
        m95b(abstractRunnableC0041f);
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: b */
    public SurfaceView m99b() {
        SurfaceView surfaceView = new SurfaceView(this.f61p);
        surfaceView.getHolder().setFormat(-3);
        surfaceView.getHolder().addCallback(new SurfaceHolder.Callback() { // from class: com.unity3d.player.UnityPlayer.16
            @Override // android.view.SurfaceHolder.Callback
            public final void surfaceChanged(SurfaceHolder surfaceHolder, int i, int i2, int i3) {
                UnityPlayer.this.m111a(0, surfaceHolder.getSurface());
            }

            @Override // android.view.SurfaceHolder.Callback
            public final void surfaceCreated(SurfaceHolder surfaceHolder) {
                UnityPlayer.this.m111a(0, surfaceHolder.getSurface());
            }

            @Override // android.view.SurfaceHolder.Callback
            public final void surfaceDestroyed(SurfaceHolder surfaceHolder) {
                UnityPlayer.this.m111a(0, (Surface) null);
            }
        });
        surfaceView.setFocusable(true);
        surfaceView.setFocusableInTouchMode(true);
        return surfaceView;
    }

    /* renamed from: b */
    private void m95b(Runnable runnable) {
        if (C0060l.m37c()) {
            if (Thread.currentThread() == this.f46a) {
                runnable.run();
            } else {
                this.f52g.add(runnable);
            }
        }
    }

    /* renamed from: b */
    private boolean m98b(final int i, final Surface surface) {
        if (C0060l.m37c()) {
            final Semaphore semaphore = new Semaphore(0);
            Runnable runnable = new Runnable() { // from class: com.unity3d.player.UnityPlayer.17
                @Override // java.lang.Runnable
                public final void run() {
                    UnityPlayer.this.nativeRecreateGfxState(i, surface);
                    semaphore.release();
                }
            };
            if (i != 0) {
                runnable.run();
            } else if (surface == null) {
                this.f46a.m61b(runnable);
            } else {
                this.f46a.m59c(runnable);
            }
            if (surface == null && i == 0) {
                try {
                    if (!semaphore.tryAcquire(4L, TimeUnit.SECONDS)) {
                        C0048e.Log(5, "Timeout while trying detaching primary window.");
                    }
                } catch (InterruptedException e) {
                    C0048e.Log(5, "UI thread got interrupted while trying to detach the primary window from the Unity Engine.");
                }
            }
            return true;
        }
        return false;
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: c */
    public void m94c() {
        if (!(this.f61p instanceof Activity) || ((Activity) this.f61p).isFinishing()) {
            return;
        }
        ((Activity) this.f61p).finish();
    }

    /* renamed from: d */
    private void m92d() {
        reportSoftInputStr(null, 1, true);
        if (this.f51f.m32g()) {
            if (C0060l.m37c()) {
                final Semaphore semaphore = new Semaphore(0);
                this.f46a.m63a(isFinishing() ? new Runnable() { // from class: com.unity3d.player.UnityPlayer.19
                    @Override // java.lang.Runnable
                    public final void run() {
                        UnityPlayer.this.m90e();
                        semaphore.release();
                    }
                } : new Runnable() { // from class: com.unity3d.player.UnityPlayer.20
                    @Override // java.lang.Runnable
                    public final void run() {
                        if (!UnityPlayer.this.nativePause()) {
                            semaphore.release();
                            return;
                        }
                        UnityPlayer.m75m(UnityPlayer.this);
                        UnityPlayer.this.m90e();
                        semaphore.release(2);
                    }
                });
                try {
                    if (!semaphore.tryAcquire(4L, TimeUnit.SECONDS)) {
                        C0048e.Log(5, "Timeout while trying to pause the Unity Engine.");
                    }
                } catch (InterruptedException e) {
                    C0048e.Log(5, "UI thread got interrupted while trying to pause the Unity Engine.");
                }
                if (semaphore.drainPermits() > 0) {
                    quit();
                }
            }
            this.f51f.m36c(false);
            this.f51f.m38b(true);
            if (this.f54i) {
                this.f56k.listen(this.f55j, 0);
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: e */
    public void m90e() {
        nativeDone();
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: f */
    public void m88f() {
        if (this.f51f.m33f()) {
            this.f51f.m36c(true);
            m95b(new Runnable() { // from class: com.unity3d.player.UnityPlayer.4
                @Override // java.lang.Runnable
                public final void run() {
                    UnityPlayer.this.nativeResume();
                }
            });
            this.f46a.m62b();
        }
    }

    /* renamed from: g */
    private static void m86g() {
        if (C0060l.m37c()) {
            if (!NativeLoader.unload()) {
                throw new UnsatisfiedLinkError("Unable to unload libraries from libmain.so");
            }
            C0060l.m39b();
        }
    }

    /* renamed from: h */
    private ApplicationInfo m84h() {
        return this.f61p.getPackageManager().getApplicationInfo(this.f61p.getPackageName(), 128);
    }

    /* renamed from: h */
    static /* synthetic */ C0056j m83h(UnityPlayer unityPlayer) {
        unityPlayer.f57l = null;
        return null;
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: i */
    public boolean m82i() {
        try {
            return m84h().metaData.getBoolean("unity.splash-enable");
        } catch (Exception e) {
            return false;
        }
    }

    private final native void initJni(Context context);

    /* renamed from: j */
    private boolean m80j() {
        try {
            return m84h().metaData.getBoolean("unity.tango-enable");
        } catch (Exception e) {
            return false;
        }
    }

    /* renamed from: k */
    private void m78k() {
        if (this.f61p instanceof Activity) {
            ((Activity) this.f61p).getWindow().setFlags(1024, 1024);
        }
    }

    protected static boolean loadLibraryStatic(String str) {
        try {
            System.loadLibrary(str);
            return true;
        } catch (Exception e) {
            C0048e.Log(6, "Unknown error " + e);
            return false;
        } catch (UnsatisfiedLinkError e2) {
            C0048e.Log(6, "Unable to find " + str);
            return false;
        }
    }

    /* renamed from: m */
    static /* synthetic */ boolean m75m(UnityPlayer unityPlayer) {
        unityPlayer.f63s = true;
        return true;
    }

    private final native void nativeDone();

    /* JADX INFO: Access modifiers changed from: private */
    public final native void nativeFocusChanged(boolean z);

    private final native void nativeInitWebRequest(Class cls);

    private final native boolean nativeInjectEvent(InputEvent inputEvent);

    /* JADX INFO: Access modifiers changed from: private */
    public final native boolean nativeIsAutorotationOn();

    /* JADX INFO: Access modifiers changed from: private */
    public final native void nativeLowMemory();

    /* JADX INFO: Access modifiers changed from: private */
    public final native void nativeMuteMasterAudio(boolean z);

    /* JADX INFO: Access modifiers changed from: private */
    public final native boolean nativePause();

    /* JADX INFO: Access modifiers changed from: private */
    public final native void nativeRecreateGfxState(int i, Surface surface);

    /* JADX INFO: Access modifiers changed from: private */
    public final native boolean nativeRender();

    private final native void nativeRestartActivityIndicator();

    /* JADX INFO: Access modifiers changed from: private */
    public final native void nativeResume();

    /* JADX INFO: Access modifiers changed from: private */
    public final native void nativeSetInputString(String str);

    /* JADX INFO: Access modifiers changed from: private */
    public final native void nativeSoftInputCanceled();

    /* JADX INFO: Access modifiers changed from: private */
    public final native void nativeSoftInputClosed();

    private final native void nativeSoftInputLostFocus();

    private static native void nativeUnitySendMessage(String str, String str2, byte[] bArr);

    /* renamed from: t */
    static /* synthetic */ C0066o m68t(UnityPlayer unityPlayer) {
        unityPlayer.f64t = null;
        return null;
    }

    /* renamed from: a */
    final void m100a(Runnable runnable) {
        if (this.f61p instanceof Activity) {
            ((Activity) this.f61p).runOnUiThread(runnable);
        } else {
            C0048e.Log(5, "Not running Unity from an Activity; ignored...");
        }
    }

    protected void addPhoneCallListener() {
        this.f54i = true;
        this.f56k.listen(this.f55j, 32);
    }

    @Override // com.unity3d.player.InterfaceC0047d
    public boolean addViewToPlayer(View view, boolean z) {
        boolean z2 = true;
        m107a(view, z ? this.f62q : null);
        boolean z3 = view.getParent() == this;
        boolean z4 = z && this.f62q.getParent() == null;
        boolean z5 = this.f62q.getParent() == this;
        if (!z3 || (!z4 && !z5)) {
            z2 = false;
        }
        if (!z2) {
            if (!z3) {
                C0048e.Log(6, "addViewToPlayer: Failure adding view to hierarchy");
            }
            if (!z4 && !z5) {
                C0048e.Log(6, "addViewToPlayer: Failure removing old view from hierarchy");
            }
        }
        return z2;
    }

    public void configurationChanged(Configuration configuration) {
        if (this.f62q instanceof SurfaceView) {
            this.f62q.getHolder().setSizeFromLayout();
        }
        if (this.f64t != null) {
            this.f64t.m13c();
        }
        GoogleVrProxy m139b = GoogleVrApi.m139b();
        if (m139b != null) {
            m139b.m128c();
        }
    }

    protected void disableLogger() {
        C0048e.f151a = true;
    }

    public boolean displayChanged(int i, Surface surface) {
        if (i == 0) {
            this.f49d = surface != null;
            m100a(new Runnable() { // from class: com.unity3d.player.UnityPlayer.18
                @Override // java.lang.Runnable
                public final void run() {
                    if (UnityPlayer.this.f49d) {
                        UnityPlayer.this.removeView(UnityPlayer.this.f62q);
                    } else {
                        UnityPlayer.this.addView(UnityPlayer.this.f62q);
                    }
                }
            });
        }
        return m98b(i, surface);
    }

    protected void executeGLThreadJobs() {
        while (true) {
            Runnable runnable = (Runnable) this.f52g.poll();
            if (runnable == null) {
                return;
            }
            runnable.run();
        }
    }

    public Bundle getSettings() {
        return Bundle.EMPTY;
    }

    protected int getSplashMode() {
        try {
            return m84h().metaData.getInt("unity.splash-mode");
        } catch (Exception e) {
            return 0;
        }
    }

    public View getView() {
        return this;
    }

    protected void hideSoftInput() {
        final Runnable runnable = new Runnable() { // from class: com.unity3d.player.UnityPlayer.6
            @Override // java.lang.Runnable
            public final void run() {
                if (UnityPlayer.this.f47b != null) {
                    UnityPlayer.this.f47b.dismiss();
                    UnityPlayer.this.f47b = null;
                }
            }
        };
        if (C0051h.f154b) {
            m106a(new AbstractRunnableC0041f() { // from class: com.unity3d.player.UnityPlayer.7
                /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
                {
                    super(UnityPlayer.this, (byte) 0);
                }

                @Override // com.unity3d.player.UnityPlayer.AbstractRunnableC0041f
                /* renamed from: a */
                public final void mo56a() {
                    UnityPlayer.this.m100a(runnable);
                }
            });
        } else {
            m100a(runnable);
        }
    }

    public void init(int i, boolean z) {
    }

    protected boolean initializeGoogleAr() {
        if (this.f58m == null && currentActivity != null && m80j()) {
            if (GoogleARProxy.m148a()) {
                this.f58m = new GoogleARProxy(this);
                this.f58m.m147a(currentActivity, this.f61p);
                this.f58m.m145b();
                if (!this.f51f.m34e()) {
                    this.f58m.m143d();
                }
                return this.f58m.m142e();
            }
            this.f59n = new GoogleARCoreApi();
            this.f59n.initializeARCore(currentActivity);
            if (!this.f51f.m34e()) {
                this.f59n.resumeARCore();
            }
        }
        return false;
    }

    protected boolean initializeGoogleVr() {
        final GoogleVrProxy m139b = GoogleVrApi.m139b();
        if (m139b == null) {
            GoogleVrApi.m140a(this);
            m139b = GoogleVrApi.m139b();
            if (m139b == null) {
                C0048e.Log(6, "Unable to create Google VR subsystem.");
                return false;
            }
        }
        final Semaphore semaphore = new Semaphore(0);
        final Runnable runnable = new Runnable() { // from class: com.unity3d.player.UnityPlayer.10
            @Override // java.lang.Runnable
            public final void run() {
                UnityPlayer.this.injectEvent(new KeyEvent(0, 4));
                UnityPlayer.this.injectEvent(new KeyEvent(1, 4));
            }
        };
        m100a(new Runnable() { // from class: com.unity3d.player.UnityPlayer.11
            @Override // java.lang.Runnable
            public final void run() {
                if (!m139b.m136a(UnityPlayer.currentActivity, UnityPlayer.this.f61p, UnityPlayer.this.m99b(), runnable)) {
                    C0048e.Log(6, "Unable to initialize Google VR subsystem.");
                }
                if (UnityPlayer.currentActivity != null) {
                    m139b.m135a(UnityPlayer.currentActivity.getIntent());
                }
                semaphore.release();
            }
        });
        try {
            if (semaphore.tryAcquire(4L, TimeUnit.SECONDS)) {
                return m139b.m138a();
            }
            C0048e.Log(5, "Timeout while trying to initialize Google VR.");
            return false;
        } catch (InterruptedException e) {
            C0048e.Log(5, "UI thread was interrupted while initializing Google VR. " + e.getLocalizedMessage());
            return false;
        }
    }

    public boolean injectEvent(InputEvent inputEvent) {
        return nativeInjectEvent(inputEvent);
    }

    protected boolean isFinishing() {
        if (!this.f63s) {
            boolean z = (this.f61p instanceof Activity) && ((Activity) this.f61p).isFinishing();
            this.f63s = z;
            if (!z) {
                return false;
            }
        }
        return true;
    }

    protected void kill() {
        Process.killProcess(Process.myPid());
    }

    protected boolean loadLibrary(String str) {
        return loadLibraryStatic(str);
    }

    public void lowMemory() {
        m95b(new Runnable() { // from class: com.unity3d.player.UnityPlayer.2
            @Override // java.lang.Runnable
            public final void run() {
                UnityPlayer.this.nativeLowMemory();
            }
        });
    }

    @Override // android.view.View
    public boolean onGenericMotionEvent(MotionEvent motionEvent) {
        return injectEvent(motionEvent);
    }

    @Override // android.view.View, android.view.KeyEvent.Callback
    public boolean onKeyDown(int i, KeyEvent keyEvent) {
        return injectEvent(keyEvent);
    }

    @Override // android.view.View, android.view.KeyEvent.Callback
    public boolean onKeyLongPress(int i, KeyEvent keyEvent) {
        return injectEvent(keyEvent);
    }

    @Override // android.view.View, android.view.KeyEvent.Callback
    public boolean onKeyMultiple(int i, int i2, KeyEvent keyEvent) {
        return injectEvent(keyEvent);
    }

    @Override // android.view.View, android.view.KeyEvent.Callback
    public boolean onKeyUp(int i, KeyEvent keyEvent) {
        return injectEvent(keyEvent);
    }

    @Override // android.view.View
    public boolean onTouchEvent(MotionEvent motionEvent) {
        return injectEvent(motionEvent);
    }

    public void pause() {
        if (this.f58m != null) {
            this.f58m.m144c();
        } else if (this.f59n != null) {
            this.f59n.pauseARCore();
        }
        if (this.f64t != null) {
            this.f64t.m20a();
        }
        GoogleVrProxy m139b = GoogleVrApi.m139b();
        if (m139b != null) {
            m139b.pauseGvrLayout();
        }
        m92d();
    }

    public void quit() {
        if (GoogleVrApi.m139b() != null) {
            GoogleVrApi.m141a();
        }
        this.f63s = true;
        if (!this.f51f.m34e()) {
            pause();
        }
        this.f46a.m65a();
        try {
            this.f46a.join(4000L);
        } catch (InterruptedException e) {
            this.f46a.interrupt();
        }
        if (this.f53h != null) {
            this.f61p.unregisterReceiver(this.f53h);
        }
        this.f53h = null;
        if (C0060l.m37c()) {
            removeAllViews();
        }
        kill();
        m86g();
    }

    @Override // com.unity3d.player.InterfaceC0047d
    public void removeViewFromPlayer(View view) {
        boolean z = true;
        m107a(this.f62q, view);
        boolean z2 = view.getParent() == null;
        boolean z3 = this.f62q.getParent() == this;
        if (!z2 || !z3) {
            z = false;
        }
        if (z) {
            return;
        }
        if (!z2) {
            C0048e.Log(6, "removeViewFromPlayer: Failure removing view from hierarchy");
        }
        if (z3) {
            return;
        }
        C0048e.Log(6, "removeVireFromPlayer: Failure agging old view to hierarchy");
    }

    @Override // com.unity3d.player.InterfaceC0047d
    public void reportError(String str, String str2) {
        C0048e.Log(6, str + ": " + str2);
    }

    /* JADX INFO: Access modifiers changed from: protected */
    public void reportSoftInputStr(final String str, final int i, final boolean z) {
        if (i == 1) {
            hideSoftInput();
        }
        m106a(new AbstractRunnableC0041f() { // from class: com.unity3d.player.UnityPlayer.9
            /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
            {
                super(UnityPlayer.this, (byte) 0);
            }

            @Override // com.unity3d.player.UnityPlayer.AbstractRunnableC0041f
            /* renamed from: a */
            public final void mo56a() {
                if (z) {
                    UnityPlayer.this.nativeSoftInputCanceled();
                } else if (str != null) {
                    UnityPlayer.this.nativeSetInputString(str);
                }
                if (i == 1) {
                    UnityPlayer.this.nativeSoftInputClosed();
                }
            }
        });
    }

    public void resume() {
        if (this.f58m != null) {
            this.f58m.m143d();
        } else if (this.f59n != null) {
            this.f59n.resumeARCore();
        }
        this.f51f.m38b(false);
        if (this.f64t != null) {
            this.f64t.m15b();
        }
        m88f();
        nativeRestartActivityIndicator();
        GoogleVrProxy m139b = GoogleVrApi.m139b();
        if (m139b != null) {
            m139b.m130b();
        }
    }

    protected void setSoftInputStr(final String str) {
        m100a(new Runnable() { // from class: com.unity3d.player.UnityPlayer.8
            @Override // java.lang.Runnable
            public final void run() {
                if (UnityPlayer.this.f47b == null || str == null) {
                    return;
                }
                UnityPlayer.this.f47b.m46a(str);
            }
        });
    }

    protected void showSoftInput(final String str, final int i, final boolean z, final boolean z2, final boolean z3, final boolean z4, final String str2) {
        m100a(new Runnable() { // from class: com.unity3d.player.UnityPlayer.5
            @Override // java.lang.Runnable
            public final void run() {
                UnityPlayer.this.f47b = new DialogC0052i(UnityPlayer.this.f61p, this, str, i, z, z2, z3, str2);
                UnityPlayer.this.f47b.show();
            }
        });
    }

    protected boolean showVideoPlayer(String str, int i, int i2, int i3, boolean z, int i4, int i5) {
        if (this.f64t == null) {
            this.f64t = new C0066o(this);
        }
        boolean m19a = this.f64t.m19a(this.f61p, str, i, i2, i3, z, i4, i5, new C0066o.InterfaceC0073a() { // from class: com.unity3d.player.UnityPlayer.12
            @Override // com.unity3d.player.C0066o.InterfaceC0073a
            /* renamed from: a */
            public final void mo4a() {
                UnityPlayer.m68t(UnityPlayer.this);
            }
        });
        if (m19a) {
            m100a(new Runnable() { // from class: com.unity3d.player.UnityPlayer.14
                @Override // java.lang.Runnable
                public final void run() {
                    if (UnityPlayer.this.nativeIsAutorotationOn() && (UnityPlayer.this.f61p instanceof Activity)) {
                        ((Activity) UnityPlayer.this.f61p).setRequestedOrientation(UnityPlayer.this.f48c);
                    }
                }
            });
        }
        return m19a;
    }

    public void start() {
    }

    public void stop() {
    }

    protected void toggleGyroscopeSensor(boolean z) {
        SensorManager sensorManager = (SensorManager) this.f61p.getSystemService("sensor");
        Sensor defaultSensor = sensorManager.getDefaultSensor(11);
        if (z) {
            sensorManager.registerListener(this.f60o, defaultSensor, 1);
        } else {
            sensorManager.unregisterListener(this.f60o);
        }
    }

    public void windowFocusChanged(boolean z) {
        this.f51f.m40a(z);
        if (z && this.f47b != null) {
            nativeSoftInputLostFocus();
            reportSoftInputStr(null, 1, false);
        }
        if (z) {
            this.f46a.m60c();
        } else {
            this.f46a.m58d();
        }
        m88f();
    }
}
