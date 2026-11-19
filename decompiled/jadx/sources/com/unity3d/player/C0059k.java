package com.unity3d.player;

import android.os.Build;
import java.lang.Thread;
/* renamed from: com.unity3d.player.k */
/* loaded from: classes.dex */
final class C0059k implements Thread.UncaughtExceptionHandler {

    /* renamed from: a */
    private volatile Thread.UncaughtExceptionHandler f175a;

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: a */
    public final synchronized boolean m42a() {
        boolean z;
        Thread.UncaughtExceptionHandler defaultUncaughtExceptionHandler = Thread.getDefaultUncaughtExceptionHandler();
        if (defaultUncaughtExceptionHandler == this) {
            z = false;
        } else {
            this.f175a = defaultUncaughtExceptionHandler;
            Thread.setDefaultUncaughtExceptionHandler(this);
            z = true;
        }
        return z;
    }

    @Override // java.lang.Thread.UncaughtExceptionHandler
    public final synchronized void uncaughtException(Thread thread, Throwable th) {
        try {
            Error error = new Error(String.format("FATAL EXCEPTION [%s]\n", thread.getName()) + String.format("Unity version     : %s\n", "2017.4.36f1") + String.format("Device model      : %s %s\n", Build.MANUFACTURER, Build.MODEL) + String.format("Device fingerprint: %s\n", Build.FINGERPRINT));
            error.setStackTrace(new StackTraceElement[0]);
            error.initCause(th);
            this.f175a.uncaughtException(thread, error);
        } catch (Throwable th2) {
            this.f175a.uncaughtException(thread, th);
        }
    }
}
