package org.fmod;

import android.media.AudioRecord;
import android.util.Log;
import java.nio.ByteBuffer;
/* JADX INFO: Access modifiers changed from: package-private */
/* renamed from: org.fmod.a */
/* loaded from: classes.dex */
public final class RunnableC0076a implements Runnable {

    /* renamed from: a */
    private final FMODAudioDevice f249a;

    /* renamed from: b */
    private final ByteBuffer f250b;

    /* renamed from: c */
    private final int f251c;

    /* renamed from: d */
    private final int f252d;

    /* renamed from: e */
    private final int f253e = 2;

    /* renamed from: f */
    private volatile Thread f254f;

    /* renamed from: g */
    private volatile boolean f255g;

    /* renamed from: h */
    private AudioRecord f256h;

    /* renamed from: i */
    private boolean f257i;

    /* JADX INFO: Access modifiers changed from: package-private */
    public RunnableC0076a(FMODAudioDevice fMODAudioDevice, int i, int i2) {
        this.f249a = fMODAudioDevice;
        this.f251c = i;
        this.f252d = i2;
        this.f250b = ByteBuffer.allocateDirect(AudioRecord.getMinBufferSize(i, i2, 2));
    }

    /* renamed from: d */
    private void m0d() {
        if (this.f256h != null) {
            if (this.f256h.getState() == 1) {
                this.f256h.stop();
            }
            this.f256h.release();
            this.f256h = null;
        }
        this.f250b.position(0);
        this.f257i = false;
    }

    /* renamed from: a */
    public final int m3a() {
        return this.f250b.capacity();
    }

    /* renamed from: b */
    public final void m2b() {
        if (this.f254f != null) {
            m1c();
        }
        this.f255g = true;
        this.f254f = new Thread(this);
        this.f254f.start();
    }

    /* renamed from: c */
    public final void m1c() {
        while (this.f254f != null) {
            this.f255g = false;
            try {
                this.f254f.join();
                this.f254f = null;
            } catch (InterruptedException e) {
            }
        }
    }

    @Override // java.lang.Runnable
    public final void run() {
        int i;
        int i2 = 3;
        while (this.f255g) {
            if (!this.f257i && i2 > 0) {
                m0d();
                this.f256h = new AudioRecord(1, this.f251c, this.f252d, this.f253e, this.f250b.capacity());
                this.f257i = this.f256h.getState() == 1;
                if (this.f257i) {
                    this.f250b.position(0);
                    this.f256h.startRecording();
                    i = 3;
                    if (this.f257i || this.f256h.getRecordingState() != 3) {
                        i2 = i;
                    } else {
                        this.f249a.fmodProcessMicData(this.f250b, this.f256h.read(this.f250b, this.f250b.capacity()));
                        this.f250b.position(0);
                        i2 = i;
                    }
                } else {
                    Log.e("FMOD", "AudioRecord failed to initialize (status " + this.f256h.getState() + ")");
                    i2--;
                    m0d();
                }
            }
            i = i2;
            if (this.f257i) {
            }
            i2 = i;
        }
        m0d();
    }
}
