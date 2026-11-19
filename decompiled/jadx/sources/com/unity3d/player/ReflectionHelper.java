package com.unity3d.player;

import java.lang.reflect.Array;
import java.lang.reflect.Constructor;
import java.lang.reflect.Field;
import java.lang.reflect.InvocationHandler;
import java.lang.reflect.Member;
import java.lang.reflect.Method;
import java.lang.reflect.Modifier;
import java.lang.reflect.Proxy;
import java.util.ArrayList;
import java.util.Iterator;
import net.codestage.actk.androidnative.BuildConfig;
/* loaded from: classes.dex */
final class ReflectionHelper {
    protected static final boolean LOGV = false;
    protected static boolean LOG = false;

    /* renamed from: a */
    private static C0012a[] f35a = new C0012a[4096];

    /* renamed from: b */
    private static long f36b = 0;

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: com.unity3d.player.ReflectionHelper$a */
    /* loaded from: classes.dex */
    public static class C0012a {

        /* renamed from: a */
        public volatile Member f40a;

        /* renamed from: b */
        private final Class f41b;

        /* renamed from: c */
        private final String f42c;

        /* renamed from: d */
        private final String f43d;

        /* renamed from: e */
        private final int f44e;

        C0012a(Class cls, String str, String str2) {
            this.f41b = cls;
            this.f42c = str;
            this.f43d = str2;
            this.f44e = ((((this.f41b.hashCode() + 527) * 31) + this.f42c.hashCode()) * 31) + this.f43d.hashCode();
        }

        public final boolean equals(Object obj) {
            if (obj == this) {
                return true;
            }
            if (obj instanceof C0012a) {
                C0012a c0012a = (C0012a) obj;
                return this.f44e == c0012a.f44e && this.f43d.equals(c0012a.f43d) && this.f42c.equals(c0012a.f42c) && this.f41b.equals(c0012a.f41b);
            }
            return false;
        }

        public final int hashCode() {
            return this.f44e;
        }
    }

    ReflectionHelper() {
    }

    /* renamed from: a */
    private static float m116a(Class cls, Class cls2) {
        if (cls.equals(cls2)) {
            return 1.0f;
        }
        if (!cls.isPrimitive() && !cls2.isPrimitive()) {
            try {
                if (cls.asSubclass(cls2) != null) {
                    return 0.5f;
                }
            } catch (ClassCastException e) {
            }
            try {
                if (cls2.asSubclass(cls) != null) {
                    return 0.1f;
                }
            } catch (ClassCastException e2) {
            }
        }
        return 0.0f;
    }

    /* renamed from: a */
    private static float m115a(Class cls, Class[] clsArr, Class[] clsArr2) {
        if (clsArr2.length == 0) {
            return 0.1f;
        }
        if ((clsArr == null ? 0 : clsArr.length) + 1 != clsArr2.length) {
            return 0.0f;
        }
        float f = 1.0f;
        if (clsArr != null) {
            int length = clsArr.length;
            int i = 0;
            int i2 = 0;
            while (i < length) {
                f *= m116a(clsArr[i], clsArr2[i2]);
                i++;
                i2++;
            }
        }
        return f * m116a(cls, clsArr2[clsArr2.length - 1]);
    }

    /* renamed from: a */
    private static Class m113a(String str, int[] iArr) {
        while (true) {
            if (iArr[0] >= str.length()) {
                break;
            }
            int i = iArr[0];
            iArr[0] = i + 1;
            char charAt = str.charAt(i);
            if (charAt != '(' && charAt != ')') {
                if (charAt == 'L') {
                    int indexOf = str.indexOf(59, iArr[0]);
                    if (indexOf != -1) {
                        String substring = str.substring(iArr[0], indexOf);
                        iArr[0] = indexOf + 1;
                        try {
                            return Class.forName(substring.replace('/', '.'));
                        } catch (ClassNotFoundException e) {
                        }
                    }
                } else if (charAt == 'Z') {
                    return Boolean.TYPE;
                } else {
                    if (charAt == 'I') {
                        return Integer.TYPE;
                    }
                    if (charAt == 'F') {
                        return Float.TYPE;
                    }
                    if (charAt == 'V') {
                        return Void.TYPE;
                    }
                    if (charAt == 'B') {
                        return Byte.TYPE;
                    }
                    if (charAt == 'S') {
                        return Short.TYPE;
                    }
                    if (charAt == 'J') {
                        return Long.TYPE;
                    }
                    if (charAt == 'D') {
                        return Double.TYPE;
                    }
                    if (charAt == '[') {
                        return Array.newInstance(m113a(str, iArr), 0).getClass();
                    }
                    C0048e.Log(5, "! parseType; " + charAt + " is not known!");
                }
            }
        }
        return null;
    }

    /* renamed from: a */
    private static void m117a(C0012a c0012a, Member member) {
        c0012a.f40a = member;
        f35a[c0012a.hashCode() & (f35a.length - 1)] = c0012a;
    }

    /* renamed from: a */
    private static boolean m118a(C0012a c0012a) {
        C0012a c0012a2 = f35a[c0012a.hashCode() & (f35a.length - 1)];
        if (c0012a.equals(c0012a2)) {
            c0012a.f40a = c0012a2.f40a;
            return true;
        }
        return false;
    }

    /* renamed from: a */
    private static Class[] m114a(String str) {
        Class m113a;
        int[] iArr = {0};
        ArrayList arrayList = new ArrayList();
        while (iArr[0] < str.length() && (m113a = m113a(str, iArr)) != null) {
            arrayList.add(m113a);
        }
        Class[] clsArr = new Class[arrayList.size()];
        Iterator it = arrayList.iterator();
        int i = 0;
        while (it.hasNext()) {
            clsArr[i] = (Class) it.next();
            i++;
        }
        return clsArr;
    }

    protected static void endUnityLaunch() {
        f36b++;
    }

    protected static Constructor getConstructorID(Class cls, String str) {
        Constructor<?> constructor;
        Constructor<?> constructor2;
        Constructor<?> constructor3 = null;
        C0012a c0012a = new C0012a(cls, BuildConfig.FLAVOR, str);
        if (m118a(c0012a)) {
            constructor2 = (Constructor) c0012a.f40a;
        } else {
            Class[] m114a = m114a(str);
            float f = 0.0f;
            Constructor<?>[] constructors = cls.getConstructors();
            int length = constructors.length;
            int i = 0;
            while (true) {
                if (i >= length) {
                    constructor = constructor3;
                    break;
                }
                constructor = constructors[i];
                float m115a = m115a(Void.TYPE, constructor.getParameterTypes(), m114a);
                if (m115a <= f) {
                    m115a = f;
                    constructor = constructor3;
                } else if (m115a == 1.0f) {
                    break;
                }
                i++;
                f = m115a;
                constructor3 = constructor;
            }
            m117a(c0012a, constructor);
            constructor2 = constructor;
        }
        if (constructor2 == null) {
            throw new NoSuchMethodError("<init>" + str + " in class " + cls.getName());
        }
        return constructor2;
    }

    protected static Field getFieldID(Class cls, String str, String str2, boolean z) {
        Field field;
        float f;
        Field field2 = null;
        C0012a c0012a = new C0012a(cls, str, str2);
        if (m118a(c0012a)) {
            field2 = (Field) c0012a.f40a;
        } else {
            Class[] m114a = m114a(str2);
            float f2 = 0.0f;
            while (cls != null) {
                Field[] declaredFields = cls.getDeclaredFields();
                int length = declaredFields.length;
                int i = 0;
                Field field3 = field2;
                while (true) {
                    if (i >= length) {
                        field = field3;
                        break;
                    }
                    field = declaredFields[i];
                    if (z == Modifier.isStatic(field.getModifiers()) && field.getName().compareTo(str) == 0) {
                        f = m115a(field.getType(), (Class[]) null, m114a);
                        if (f > f2) {
                            if (f == 1.0f) {
                                f2 = f;
                                break;
                            }
                            i++;
                            f2 = f;
                            field3 = field;
                        }
                    }
                    f = f2;
                    field = field3;
                    i++;
                    f2 = f;
                    field3 = field;
                }
                if (f2 == 1.0f || cls.isPrimitive() || cls.isInterface() || cls.equals(Object.class) || cls.equals(Void.TYPE)) {
                    field2 = field;
                    break;
                }
                cls = cls.getSuperclass();
                field2 = field;
            }
            m117a(c0012a, field2);
        }
        if (field2 == null) {
            Object[] objArr = new Object[4];
            objArr[0] = z ? "static" : "non-static";
            objArr[1] = str;
            objArr[2] = str2;
            objArr[3] = cls.getName();
            throw new NoSuchFieldError(String.format("no %s field with name='%s' signature='%s' in class L%s;", objArr));
        }
        return field2;
    }

    protected static Method getMethodID(Class cls, String str, String str2, boolean z) {
        Method method;
        float f;
        Method method2 = null;
        C0012a c0012a = new C0012a(cls, str, str2);
        if (m118a(c0012a)) {
            method2 = (Method) c0012a.f40a;
        } else {
            Class[] m114a = m114a(str2);
            float f2 = 0.0f;
            while (cls != null) {
                Method[] declaredMethods = cls.getDeclaredMethods();
                int length = declaredMethods.length;
                int i = 0;
                Method method3 = method2;
                while (true) {
                    if (i >= length) {
                        method = method3;
                        break;
                    }
                    method = declaredMethods[i];
                    if (z == Modifier.isStatic(method.getModifiers()) && method.getName().compareTo(str) == 0) {
                        f = m115a(method.getReturnType(), method.getParameterTypes(), m114a);
                        if (f > f2) {
                            if (f == 1.0f) {
                                f2 = f;
                                break;
                            }
                            i++;
                            f2 = f;
                            method3 = method;
                        }
                    }
                    f = f2;
                    method = method3;
                    i++;
                    f2 = f;
                    method3 = method;
                }
                if (f2 == 1.0f || cls.isPrimitive() || cls.isInterface() || cls.equals(Object.class) || cls.equals(Void.TYPE)) {
                    method2 = method;
                    break;
                }
                cls = cls.getSuperclass();
                method2 = method;
            }
            m117a(c0012a, method2);
        }
        if (method2 == null) {
            Object[] objArr = new Object[4];
            objArr[0] = z ? "static" : "non-static";
            objArr[1] = str;
            objArr[2] = str2;
            objArr[3] = cls.getName();
            throw new NoSuchMethodError(String.format("no %s method with name='%s' signature='%s' in class L%s;", objArr));
        }
        return method2;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static native void nativeProxyFinalize(int i);

    /* JADX INFO: Access modifiers changed from: private */
    public static native Object nativeProxyInvoke(int i, String str, Object[] objArr);

    protected static Object newProxyInstance(int i, Class cls) {
        return newProxyInstance(i, new Class[]{cls});
    }

    protected static Object newProxyInstance(final int i, final Class[] clsArr) {
        return Proxy.newProxyInstance(ReflectionHelper.class.getClassLoader(), clsArr, new InvocationHandler() { // from class: com.unity3d.player.ReflectionHelper.1

            /* renamed from: c */
            private long f39c = ReflectionHelper.f36b;

            protected final void finalize() {
                try {
                    if (this.f39c == ReflectionHelper.f36b) {
                        ReflectionHelper.nativeProxyFinalize(i);
                    }
                } finally {
                    super.finalize();
                }
            }

            @Override // java.lang.reflect.InvocationHandler
            public final Object invoke(Object obj, Method method, Object[] objArr) {
                if (this.f39c != ReflectionHelper.f36b) {
                    C0048e.Log(6, "Scripting proxy object was destroyed, because Unity player was unloaded.");
                    return null;
                }
                return ReflectionHelper.nativeProxyInvoke(i, method.getName(), objArr);
            }
        });
    }
}
