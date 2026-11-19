package com.unity3d.player;

import android.os.Build;
import java.net.InetAddress;
import java.net.Socket;
import javax.net.ssl.HandshakeCompletedEvent;
import javax.net.ssl.HandshakeCompletedListener;
import javax.net.ssl.SSLContext;
import javax.net.ssl.SSLPeerUnverifiedException;
import javax.net.ssl.SSLSession;
import javax.net.ssl.SSLSocket;
import javax.net.ssl.SSLSocketFactory;
/* renamed from: com.unity3d.player.a */
/* loaded from: classes.dex */
public final class C0042a extends SSLSocketFactory {

    /* renamed from: c */
    private static volatile SSLSocketFactory f137c;

    /* renamed from: d */
    private static final Object[] f138d = new Object[0];

    /* renamed from: e */
    private static final boolean f139e;

    /* renamed from: a */
    private final SSLSocketFactory f140a;

    /* renamed from: b */
    private final C0043a f141b;

    /* renamed from: com.unity3d.player.a$a */
    /* loaded from: classes.dex */
    class C0043a implements HandshakeCompletedListener {
        C0043a() {
        }

        @Override // javax.net.ssl.HandshakeCompletedListener
        public final void handshakeCompleted(HandshakeCompletedEvent handshakeCompletedEvent) {
            SSLSession session = handshakeCompletedEvent.getSession();
            session.getCipherSuite();
            session.getProtocol();
            try {
                session.getPeerPrincipal().getName();
            } catch (SSLPeerUnverifiedException e) {
            }
        }
    }

    static {
        boolean z = false;
        if (Build.VERSION.SDK_INT >= 16 && Build.VERSION.SDK_INT < 20) {
            z = true;
        }
        f139e = z;
    }

    private C0042a() {
        SSLContext sSLContext = SSLContext.getInstance("TLS");
        sSLContext.init(null, null, null);
        this.f140a = sSLContext.getSocketFactory();
        this.f141b = new C0043a();
    }

    /* renamed from: a */
    private static Socket m54a(Socket socket) {
        if (socket != null && (socket instanceof SSLSocket) && f139e) {
            ((SSLSocket) socket).setEnabledProtocols(((SSLSocket) socket).getSupportedProtocols());
        }
        return socket;
    }

    /* renamed from: a */
    public static SSLSocketFactory m55a() {
        synchronized (f138d) {
            if (f137c != null) {
                return f137c;
            }
            try {
                C0042a c0042a = new C0042a();
                f137c = c0042a;
                return c0042a;
            } catch (Exception e) {
                C0048e.Log(5, "CustomSSLSocketFactory: Failed to create SSLSocketFactory (" + e.getMessage() + ")");
                return null;
            }
        }
    }

    @Override // javax.net.SocketFactory
    public final Socket createSocket() {
        return m54a(this.f140a.createSocket());
    }

    @Override // javax.net.SocketFactory
    public final Socket createSocket(String str, int i) {
        return m54a(this.f140a.createSocket(str, i));
    }

    @Override // javax.net.SocketFactory
    public final Socket createSocket(String str, int i, InetAddress inetAddress, int i2) {
        return m54a(this.f140a.createSocket(str, i, inetAddress, i2));
    }

    @Override // javax.net.SocketFactory
    public final Socket createSocket(InetAddress inetAddress, int i) {
        return m54a(this.f140a.createSocket(inetAddress, i));
    }

    @Override // javax.net.SocketFactory
    public final Socket createSocket(InetAddress inetAddress, int i, InetAddress inetAddress2, int i2) {
        return m54a(this.f140a.createSocket(inetAddress, i, inetAddress2, i2));
    }

    @Override // javax.net.ssl.SSLSocketFactory
    public final Socket createSocket(Socket socket, String str, int i, boolean z) {
        return m54a(this.f140a.createSocket(socket, str, i, z));
    }

    @Override // javax.net.ssl.SSLSocketFactory
    public final String[] getDefaultCipherSuites() {
        return this.f140a.getDefaultCipherSuites();
    }

    @Override // javax.net.ssl.SSLSocketFactory
    public final String[] getSupportedCipherSuites() {
        return this.f140a.getSupportedCipherSuites();
    }
}
