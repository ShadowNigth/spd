package org.fmod;

import android.media.AudioTrack;
import android.util.Log;
import java.nio.ByteBuffer;
/* loaded from: classes.dex */
public class FMODAudioDevice implements Runnable {

    /* renamed from: h */
    private static int f238h = 0;

    /* renamed from: i */
    private static int f239i = 1;

    /* renamed from: j */
    private static int f240j = 2;

    /* renamed from: k */
    private static int f241k = 3;

    /* renamed from: a */
    private volatile Thread f242a = null;

    /* renamed from: b */
    private volatile boolean f243b = false;

    /* renamed from: c */
    private AudioTrack f244c = null;

    /* renamed from: d */
    private boolean f245d = false;

    /* renamed from: e */
    private ByteBuffer f246e = null;

    /* renamed from: f */
    private byte[] f247f = null;

    /* renamed from: g */
    private volatile RunnableC0076a f248g;

    private native int fmodGetInfo(int i);

    private native int fmodProcess(ByteBuffer byteBuffer);

    private void releaseAudioTrack() {
        if (this.f244c != null) {
            if (this.f244c.getState() == 1) {
                this.f244c.stop();
            }
            this.f244c.release();
            this.f244c = null;
        }
        this.f246e = null;
        this.f247f = null;
        this.f245d = false;
    }

    public synchronized void close() {
        stop();
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    public native int fmodProcessMicData(ByteBuffer byteBuffer, int i);

    public boolean isRunning() {
        return this.f242a != null && this.f242a.isAlive();
    }

    @Override // java.lang.Runnable
    public void run() {
        int i;
        int i2 = 3;
        while (this.f243b) {
            if (this.f245d || i2 <= 0) {
                i = i2;
            } else {
                releaseAudioTrack();
                int fmodGetInfo = fmodGetInfo(f238h);
                int round = Math.round(AudioTrack.getMinBufferSize(fmodGetInfo, 3, 2) * 1.1f) & (-4);
                int fmodGetInfo2 = fmodGetInfo(f239i);
                int fmodGetInfo3 = fmodGetInfo(f240j);
                if (fmodGetInfo2 * fmodGetInfo3 * 4 > round) {
                    round = fmodGetInfo3 * fmodGetInfo2 * 4;
                }
                this.f244c = new AudioTrack(3, fmodGetInfo, 3, 2, round, 1);
                this.f245d = this.f244c.getState() == 1;
                if (this.f245d) {
                    this.f246e = ByteBuffer.allocateDirect(fmodGetInfo2 * 2 * 2);
                    this.f247f = new byte[this.f246e.capacity()];
                    this.f244c.play();
                    i = 3;
                } else {
                    Log.e("FMOD", "AudioTrack failed to initialize (status " + this.f244c.getState() + ")");
                    releaseAudioTrack();
                    i = i2 - 1;
                }
            }
            if (!this.f245d) {
                i2 = i;
            } else if (fmodGetInfo(f241k) == 1) {
                fmodProcess(this.f246e);
                this.f246e.get(this.f247f, 0, this.f246e.capacity());
                this.f244c.write(this.f247f, 0, this.f246e.capacity());
                this.f246e.position(0);
                i2 = i;
            } else {
                releaseAudioTrack();
                i2 = i;
            }
        }
        releaseAudioTrack();
    }

    public synchronized void start() {
        if (this.f242a != null) {
            stop();
        }
        this.f242a = new Thread(this, "FMODAudioDevice");
        this.f242a.setPriority(10);
        this.f243b = true;
        this.f242a.start();
        if (this.f248g != null) {
            this.f248g.m2b();
        }
    }

    public synchronized int startAudioRecord(int i, int i2, int i3) {
        if (this.f248g == null) {
            this.f248g = new RunnableC0076a(this, i, i2);
            this.f248g.m2b();
        }
        return this.f248g.m3a();
    }

    public synchronized void stop() {
        while (this.f242a != null) {
            this.f243b = false;
            try {
                this.f242a.join();
                this.f242a = null;
            } catch (InterruptedException e) {
            }
        }
        if (this.f248g != null) {
            this.f248g.m1c();
        }
    }

    public synchronized void stopAudioRecord() {
        if (this.f248g != null) {
            this.f248g.m1c();
            this.f248g = null;
        }
    }
}
