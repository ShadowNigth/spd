package bitter.jnibridge;

import java.lang.reflect.InvocationHandler;
import java.lang.reflect.Method;
import java.lang.reflect.Proxy;
/* loaded from: classes.dex */
public class JNIBridge {

    /* renamed from: bitter.jnibridge.JNIBridge$a */
    /* loaded from: classes.dex */
    private static class C0000a implements InvocationHandler {

        /* renamed from: a */
        private Object f0a = new Object[0];

        /* renamed from: b */
        private long f1b;

        public C0000a(long j) {
            this.f1b = j;
        }

        /* renamed from: a */
        public final void m149a() {
            synchronized (this.f0a) {
                this.f1b = 0L;
            }
        }

        public final void finalize() {
            synchronized (this.f0a) {
                if (this.f1b == 0) {
                    return;
                }
                JNIBridge.delete(this.f1b);
            }
        }

        @Override // java.lang.reflect.InvocationHandler
        public final Object invoke(Object obj, Method method, Object[] objArr) {
            Object invoke;
            synchronized (this.f0a) {
                invoke = this.f1b == 0 ? null : JNIBridge.invoke(this.f1b, method.getDeclaringClass(), method, objArr);
            }
            return invoke;
        }
    }

    static native void delete(long j);

    static void disableInterfaceProxy(Object obj) {
        ((C0000a) Proxy.getInvocationHandler(obj)).m149a();
    }

    static native Object invoke(long j, Class cls, Method method, Object[] objArr);

    static Object newInterfaceProxy(long j, Class[] clsArr) {
        return Proxy.newProxyInstance(JNIBridge.class.getClassLoader(), clsArr, new C0000a(j));
    }
}
