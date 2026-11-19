package com.unity3d.player;

import java.lang.reflect.Method;
import java.util.HashMap;
/* renamed from: com.unity3d.player.m */
/* loaded from: classes.dex */
final class C0061m {

    /* renamed from: a */
    private HashMap f181a = new HashMap();

    /* renamed from: b */
    private Class f182b;

    /* renamed from: c */
    private Object f183c;

    /* JADX INFO: Access modifiers changed from: package-private */
    /* renamed from: com.unity3d.player.m$a */
    /* loaded from: classes.dex */
    public class C0062a {

        /* renamed from: a */
        public Class[] f184a;

        /* renamed from: b */
        public Method f185b = null;

        public C0062a(Class[] clsArr) {
            this.f184a = clsArr;
        }
    }

    public C0061m(Class cls, Object obj) {
        this.f182b = null;
        this.f183c = null;
        this.f182b = cls;
        this.f183c = obj;
    }

    /* renamed from: a */
    private void m31a(String str, C0062a c0062a) {
        try {
            c0062a.f185b = this.f182b.getMethod(str, c0062a.f184a);
        } catch (Exception e) {
            C0048e.Log(6, "Exception while trying to get method " + str + ". " + e.getLocalizedMessage());
            c0062a.f185b = null;
        }
    }

    /* renamed from: a */
    public final Object m29a(String str, Object... objArr) {
        Object obj;
        if (!this.f181a.containsKey(str)) {
            C0048e.Log(6, "No definition for method " + str + " can be found");
            return null;
        }
        C0062a c0062a = (C0062a) this.f181a.get(str);
        if (c0062a.f185b == null) {
            m31a(str, c0062a);
        }
        if (c0062a.f185b == null) {
            C0048e.Log(6, "Unable to create method: " + str);
            return null;
        }
        try {
            obj = objArr.length == 0 ? c0062a.f185b.invoke(this.f183c, new Object[0]) : c0062a.f185b.invoke(this.f183c, objArr);
        } catch (Exception e) {
            C0048e.Log(6, "Error trying to call delegated method " + str + ". " + e.getLocalizedMessage());
            obj = null;
        }
        return obj;
    }

    /* renamed from: a */
    public final void m30a(String str, Class[] clsArr) {
        this.f181a.put(str, new C0062a(clsArr));
    }
}
