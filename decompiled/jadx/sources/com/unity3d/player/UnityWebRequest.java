package com.unity3d.player;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.CookieHandler;
import java.net.CookieManager;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.ProtocolException;
import java.net.SocketTimeoutException;
import java.net.URL;
import java.net.URLConnection;
import java.net.UnknownHostException;
import java.nio.ByteBuffer;
import java.nio.channels.Channels;
import java.nio.channels.ReadableByteChannel;
import java.util.List;
import java.util.Map;
import javax.net.ssl.HttpsURLConnection;
import javax.net.ssl.SSLException;
import javax.net.ssl.SSLSocketFactory;
/* loaded from: classes.dex */
class UnityWebRequest implements Runnable {

    /* renamed from: a */
    private long f131a;

    /* renamed from: b */
    private String f132b;

    /* renamed from: c */
    private String f133c;

    /* renamed from: d */
    private Map f134d;

    /* renamed from: e */
    private int f135e;

    /* renamed from: f */
    private long f136f;

    static {
        if (CookieHandler.getDefault() == null) {
            CookieHandler.setDefault(new CookieManager());
        }
    }

    UnityWebRequest(long j, String str, Map map, String str2, int i) {
        this.f131a = j;
        this.f132b = str2;
        this.f133c = str;
        this.f134d = map;
        this.f135e = i;
    }

    private static native void contentLengthCallback(long j, int i);

    private static native boolean downloadCallback(long j, ByteBuffer byteBuffer, int i);

    private static native void errorCallback(long j, int i, String str);

    private boolean hasTimedOut() {
        return this.f135e > 0 && System.currentTimeMillis() - this.f136f >= ((long) this.f135e);
    }

    private static native void headerCallback(long j, String str, String str2);

    private static native void responseCodeCallback(long j, int i);

    private void runSafe() {
        InputStream inputStream;
        SSLSocketFactory m55a;
        this.f136f = System.currentTimeMillis();
        try {
            URL url = new URL(this.f132b);
            URLConnection openConnection = url.openConnection();
            openConnection.setConnectTimeout(this.f135e);
            openConnection.setReadTimeout(this.f135e);
            if ((openConnection instanceof HttpsURLConnection) && (m55a = C0042a.m55a()) != null) {
                ((HttpsURLConnection) openConnection).setSSLSocketFactory(m55a);
            }
            if (url.getProtocol().equalsIgnoreCase("file") && !url.getHost().isEmpty()) {
                malformattedUrlCallback("file:// must use an absolute path");
                return;
            }
            if (openConnection instanceof HttpURLConnection) {
                try {
                    HttpURLConnection httpURLConnection = (HttpURLConnection) openConnection;
                    httpURLConnection.setRequestMethod(this.f133c);
                    httpURLConnection.setInstanceFollowRedirects(false);
                } catch (ProtocolException e) {
                    badProtocolCallback(e.toString());
                    return;
                }
            }
            if (this.f134d != null) {
                for (Map.Entry entry : this.f134d.entrySet()) {
                    openConnection.addRequestProperty((String) entry.getKey(), (String) entry.getValue());
                }
            }
            ByteBuffer allocateDirect = ByteBuffer.allocateDirect(131072);
            if (uploadCallback(null) > 0) {
                openConnection.setDoOutput(true);
                try {
                    OutputStream outputStream = openConnection.getOutputStream();
                    int uploadCallback = uploadCallback(allocateDirect);
                    while (uploadCallback > 0) {
                        if (hasTimedOut()) {
                            outputStream.close();
                            errorCallback(this.f131a, 14, "WebRequest timed out.");
                            return;
                        }
                        outputStream.write(allocateDirect.array(), allocateDirect.arrayOffset(), uploadCallback);
                        uploadCallback = uploadCallback(allocateDirect);
                    }
                } catch (Exception e2) {
                    errorCallback(e2.toString());
                    return;
                }
            }
            if (openConnection instanceof HttpURLConnection) {
                try {
                    responseCodeCallback(((HttpURLConnection) openConnection).getResponseCode());
                } catch (SocketTimeoutException e3) {
                    errorCallback(this.f131a, 14, e3.toString());
                    return;
                } catch (UnknownHostException e4) {
                    unknownHostCallback(e4.toString());
                    return;
                } catch (SSLException e5) {
                    sslCannotConnectCallback(e5);
                    return;
                } catch (IOException e6) {
                    errorCallback(e6.toString());
                    return;
                }
            }
            Map<String, List<String>> headerFields = openConnection.getHeaderFields();
            headerCallback(headerFields);
            if ((headerFields == null || !headerFields.containsKey("content-length")) && openConnection.getContentLength() != -1) {
                headerCallback("content-length", String.valueOf(openConnection.getContentLength()));
            }
            if ((headerFields == null || !headerFields.containsKey("content-type")) && openConnection.getContentType() != null) {
                headerCallback("content-type", openConnection.getContentType());
            }
            contentLengthCallback(openConnection.getContentLength());
            try {
                if (openConnection instanceof HttpURLConnection) {
                    HttpURLConnection httpURLConnection2 = (HttpURLConnection) openConnection;
                    responseCodeCallback(httpURLConnection2.getResponseCode());
                    inputStream = httpURLConnection2.getErrorStream();
                } else {
                    inputStream = null;
                }
                if (inputStream == null) {
                    inputStream = openConnection.getInputStream();
                }
                ReadableByteChannel newChannel = Channels.newChannel(inputStream);
                for (int read = newChannel.read(allocateDirect); read != -1; read = newChannel.read(allocateDirect)) {
                    if (hasTimedOut()) {
                        newChannel.close();
                        errorCallback(this.f131a, 14, "WebRequest timed out.");
                        return;
                    }
                    if (!downloadCallback(allocateDirect, read)) {
                        break;
                    }
                    allocateDirect.clear();
                }
                newChannel.close();
            } catch (SocketTimeoutException e7) {
                errorCallback(this.f131a, 14, e7.toString());
            } catch (UnknownHostException e8) {
                unknownHostCallback(e8.toString());
            } catch (SSLException e9) {
                sslCannotConnectCallback(e9);
            } catch (IOException e10) {
                errorCallback(this.f131a, 14, e10.toString());
            } catch (Exception e11) {
                errorCallback(e11.toString());
            }
        } catch (MalformedURLException e12) {
            malformattedUrlCallback(e12.toString());
        } catch (IOException e13) {
            errorCallback(e13.toString());
        }
    }

    private static native int uploadCallback(long j, ByteBuffer byteBuffer);

    protected void badProtocolCallback(String str) {
        errorCallback(this.f131a, 4, str);
    }

    protected void contentLengthCallback(int i) {
        contentLengthCallback(this.f131a, i);
    }

    protected boolean downloadCallback(ByteBuffer byteBuffer, int i) {
        return downloadCallback(this.f131a, byteBuffer, i);
    }

    protected void errorCallback(String str) {
        errorCallback(this.f131a, 2, str);
    }

    protected void headerCallback(String str, String str2) {
        headerCallback(this.f131a, str, str2);
    }

    protected void headerCallback(Map map) {
        if (map == null || map.size() == 0) {
            return;
        }
        for (Map.Entry entry : map.entrySet()) {
            String str = (String) entry.getKey();
            if (str == null) {
                str = "Status";
            }
            for (String str2 : (List) entry.getValue()) {
                headerCallback(str, str2);
            }
        }
    }

    protected void malformattedUrlCallback(String str) {
        errorCallback(this.f131a, 5, str);
    }

    protected void responseCodeCallback(int i) {
        responseCodeCallback(this.f131a, i);
    }

    @Override // java.lang.Runnable
    public void run() {
        try {
            runSafe();
        } catch (Exception e) {
            errorCallback(e.toString());
        }
    }

    /* JADX WARN: Code restructure failed: missing block: B:13:0x001c, code lost:
        r0 = 25;
     */
    /*
        Code decompiled incorrectly, please refer to instructions dump.
        To view partially-correct add '--show-bad-code' argument
    */
    protected void sslCannotConnectCallback(javax.net.ssl.SSLException r5) {
        /*
            r4 = this;
            java.lang.String r1 = r5.toString()
            r0 = 16
        L6:
            if (r5 == 0) goto Le
            boolean r2 = r5 instanceof javax.net.ssl.SSLKeyException
            if (r2 == 0) goto L14
            r0 = 23
        Le:
            long r2 = r4.f131a
            errorCallback(r2, r0, r1)
            return
        L14:
            boolean r2 = r5 instanceof javax.net.ssl.SSLPeerUnverifiedException
            if (r2 != 0) goto L1c
            boolean r2 = r5 instanceof java.security.cert.CertPathValidatorException
            if (r2 == 0) goto L1f
        L1c:
            r0 = 25
            goto Le
        L1f:
            java.lang.Throwable r5 = r5.getCause()
            goto L6
        */
        throw new UnsupportedOperationException("Method not decompiled: com.unity3d.player.UnityWebRequest.sslCannotConnectCallback(javax.net.ssl.SSLException):void");
    }

    protected void unknownHostCallback(String str) {
        errorCallback(this.f131a, 7, str);
    }

    protected int uploadCallback(ByteBuffer byteBuffer) {
        return uploadCallback(this.f131a, byteBuffer);
    }
}
