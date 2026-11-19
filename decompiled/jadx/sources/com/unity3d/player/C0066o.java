package com.unity3d.player;

import android.app.Activity;
import android.content.Context;
import com.unity3d.player.SurfaceHolder$CallbackC0063n;
import java.util.concurrent.Semaphore;
import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;
/* JADX INFO: Access modifiers changed from: package-private */
/* renamed from: com.unity3d.player.o */
/* loaded from: classes.dex */
public final class C0066o {

    /* renamed from: a */
    private UnityPlayer f216a;

    /* renamed from: c */
    private InterfaceC0073a f218c;

    /* renamed from: b */
    private Context f217b = null;

    /* renamed from: d */
    private final Semaphore f219d = new Semaphore(0);

    /* renamed from: e */
    private final Lock f220e = new ReentrantLock();

    /* renamed from: f */
    private SurfaceHolder$CallbackC0063n f221f = null;

    /* renamed from: g */
    private int f222g = 2;

    /* renamed from: h */
    private boolean f223h = false;

    /* renamed from: i */
    private boolean f224i = false;

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: com.unity3d.player.o$1 */
    /* loaded from: classes.dex */
    public final class RunnableC00671 implements Runnable {

        /* renamed from: a */
        final /* synthetic */ String f225a;

        /* renamed from: b */
        final /* synthetic */ int f226b;

        /* renamed from: c */
        final /* synthetic */ int f227c;

        /* renamed from: d */
        final /* synthetic */ int f228d;

        /* renamed from: e */
        final /* synthetic */ boolean f229e;

        /* renamed from: f */
        final /* synthetic */ long f230f;

        /* renamed from: g */
        final /* synthetic */ long f231g;

        RunnableC00671(String str, int i, int i2, int i3, boolean z, long j, long j2) {
            this.f225a = str;
            this.f226b = i;
            this.f227c = i2;
            this.f228d = i3;
            this.f229e = z;
            this.f230f = j;
            this.f231g = j2;
        }

        @Override // java.lang.Runnable
        public final void run() {
            if (C0066o.this.f221f != null) {
                C0048e.Log(5, "Video already playing");
                C0066o.this.f222g = 2;
                C0066o.this.f219d.release();
                return;
            }
            C0066o.this.f221f = new SurfaceHolder$CallbackC0063n(C0066o.this.f217b, this.f225a, this.f226b, this.f227c, this.f228d, this.f229e, this.f230f, this.f231g, new SurfaceHolder$CallbackC0063n.InterfaceC0064a() { // from class: com.unity3d.player.o.1.1
                @Override // com.unity3d.player.SurfaceHolder$CallbackC0063n.InterfaceC0064a
                /* renamed from: a */
                public final void mo5a(int i) {
                    C0066o.this.f220e.lock();
                    C0066o.this.f222g = i;
                    if (i == 3 && C0066o.this.f224i) {
                        C0066o.this.runOnUiThread(new Runnable() { // from class: com.unity3d.player.o.1.1.1
                            @Override // java.lang.Runnable
                            public final void run() {
                                C0066o.this.m11d();
                                C0066o.this.f216a.resume();
                            }
                        });
                    }
                    if (i != 0) {
                        C0066o.this.f219d.release();
                    }
                    C0066o.this.f220e.unlock();
                }
            });
            if (C0066o.this.f221f != null) {
                C0066o.this.f216a.addView(C0066o.this.f221f);
            }
        }
    }

    /* renamed from: com.unity3d.player.o$a */
    /* loaded from: classes.dex */
    public interface InterfaceC0073a {
        /* renamed from: a */
        void mo4a();
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    public C0066o(UnityPlayer unityPlayer) {
        this.f216a = null;
        this.f216a = unityPlayer;
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: d */
    public void m11d() {
        if (this.f221f != null) {
            this.f216a.removeViewFromPlayer(this.f221f);
            this.f224i = false;
            this.f221f.destroyPlayer();
            this.f221f = null;
            if (this.f218c != null) {
                this.f218c.mo4a();
            }
        }
    }

    /* renamed from: h */
    static /* synthetic */ boolean m6h(C0066o c0066o) {
        c0066o.f224i = true;
        return true;
    }

    /* renamed from: a */
    public final void m20a() {
        this.f220e.lock();
        if (this.f221f != null) {
            if (this.f222g == 0) {
                this.f221f.CancelOnPrepare();
            } else if (this.f224i) {
                this.f223h = this.f221f.m28a();
                if (!this.f223h) {
                    this.f221f.pause();
                }
            }
        }
        this.f220e.unlock();
    }

    /* renamed from: a */
    public final boolean m19a(Context context, String str, int i, int i2, int i3, boolean z, long j, long j2, InterfaceC0073a interfaceC0073a) {
        this.f220e.lock();
        this.f218c = interfaceC0073a;
        this.f217b = context;
        this.f219d.drainPermits();
        this.f222g = 2;
        runOnUiThread(new RunnableC00671(str, i, i2, i3, z, j, j2));
        boolean z2 = false;
        try {
            this.f220e.unlock();
            this.f219d.acquire();
            this.f220e.lock();
            z2 = this.f222g != 2;
        } catch (InterruptedException e) {
        }
        runOnUiThread(new Runnable() { // from class: com.unity3d.player.o.2
            @Override // java.lang.Runnable
            public final void run() {
                C0066o.this.f216a.pause();
            }
        });
        if (!z2 || this.f222g == 3) {
            runOnUiThread(new Runnable() { // from class: com.unity3d.player.o.4
                @Override // java.lang.Runnable
                public final void run() {
                    C0066o.this.m11d();
                    C0066o.this.f216a.resume();
                }
            });
        } else {
            runOnUiThread(new Runnable() { // from class: com.unity3d.player.o.3
                @Override // java.lang.Runnable
                public final void run() {
                    if (C0066o.this.f221f != null) {
                        C0066o.this.f216a.addViewToPlayer(C0066o.this.f221f, true);
                        C0066o.m6h(C0066o.this);
                        C0066o.this.f221f.requestFocus();
                    }
                }
            });
        }
        this.f220e.unlock();
        return z2;
    }

    /* renamed from: b */
    public final void m15b() {
        this.f220e.lock();
        if (this.f221f != null && this.f224i && !this.f223h) {
            this.f221f.start();
        }
        this.f220e.unlock();
    }

    /* renamed from: c */
    public final void m13c() {
        this.f220e.lock();
        if (this.f221f != null) {
            this.f221f.updateVideoLayout();
        }
        this.f220e.unlock();
    }

    protected final void runOnUiThread(Runnable runnable) {
        if (this.f217b instanceof Activity) {
            ((Activity) this.f217b).runOnUiThread(runnable);
        } else {
            C0048e.Log(5, "Not running from an Activity; Ignoring execution request...");
        }
    }
}
