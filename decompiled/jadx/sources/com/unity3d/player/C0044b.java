package com.unity3d.player;

import android.app.Activity;
import android.content.Context;
import android.os.Looper;
import java.util.concurrent.Semaphore;
import java.util.concurrent.TimeUnit;
import net.codestage.actk.androidnative.BuildConfig;
/* JADX INFO: Access modifiers changed from: package-private */
/* renamed from: com.unity3d.player.b */
/* loaded from: classes.dex */
public class C0044b {

    /* renamed from: b */
    protected InterfaceC0047d f144b;

    /* renamed from: e */
    protected String f147e;

    /* renamed from: a */
    protected C0061m f143a = null;

    /* renamed from: c */
    protected Context f145c = null;

    /* renamed from: d */
    protected String f146d = null;

    /* JADX INFO: Access modifiers changed from: package-private */
    public C0044b(String str, InterfaceC0047d interfaceC0047d) {
        this.f144b = null;
        this.f147e = BuildConfig.FLAVOR;
        this.f147e = str;
        this.f144b = interfaceC0047d;
    }

    /* JADX INFO: Access modifiers changed from: protected */
    public void reportError(String str) {
        if (this.f144b != null) {
            this.f144b.reportError(this.f147e + " Error [" + this.f146d + "]", str);
        } else {
            C0048e.Log(6, this.f147e + " Error [" + this.f146d + "]: " + str);
        }
    }

    /* JADX INFO: Access modifiers changed from: protected */
    public void runOnUiThread(Runnable runnable) {
        if (this.f145c instanceof Activity) {
            ((Activity) this.f145c).runOnUiThread(runnable);
        } else {
            C0048e.Log(5, "Not running " + this.f147e + " from an Activity; Ignoring execution request...");
        }
    }

    /* JADX INFO: Access modifiers changed from: protected */
    public boolean runOnUiThreadWithSync(final Runnable runnable) {
        boolean z = false;
        if (Looper.getMainLooper().getThread() == Thread.currentThread()) {
            runnable.run();
            return true;
        }
        final Semaphore semaphore = new Semaphore(0);
        runOnUiThread(new Runnable() { // from class: com.unity3d.player.b.1
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    runnable.run();
                } catch (Exception e) {
                    C0044b.this.reportError("Exception unloading Google VR on UI Thread. " + e.getLocalizedMessage());
                } finally {
                    semaphore.release();
                }
            }
        });
        try {
            if (semaphore.tryAcquire(4L, TimeUnit.SECONDS)) {
                z = true;
            } else {
                reportError("Timeout waiting for vr state change!");
            }
        } catch (InterruptedException e) {
            reportError("Interrupted while trying to acquire sync lock. " + e.getLocalizedMessage());
        }
        return z;
    }
}
