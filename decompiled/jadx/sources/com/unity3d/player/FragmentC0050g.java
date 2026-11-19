package com.unity3d.player;

import android.app.Fragment;
import android.app.FragmentTransaction;
import android.os.Bundle;
/* renamed from: com.unity3d.player.g */
/* loaded from: classes.dex */
public final class FragmentC0050g extends Fragment {

    /* renamed from: a */
    private final Runnable f152a;

    public FragmentC0050g() {
        this.f152a = null;
    }

    public FragmentC0050g(Runnable runnable) {
        this.f152a = runnable;
    }

    @Override // android.app.Fragment
    public final void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        if (this.f152a == null) {
            getFragmentManager().beginTransaction().remove(this).commit();
        } else {
            requestPermissions(getArguments().getStringArray("PermissionNames"), 15881);
        }
    }

    @Override // android.app.Fragment
    public final void onRequestPermissionsResult(int i, String[] strArr, int[] iArr) {
        if (i != 15881) {
            return;
        }
        for (int i2 = 0; i2 < strArr.length && i2 < iArr.length; i2++) {
            C0048e.Log(4, strArr[i2] + (iArr[i2] == 0 ? " granted" : " denied"));
        }
        FragmentTransaction beginTransaction = getActivity().getFragmentManager().beginTransaction();
        beginTransaction.remove(this);
        beginTransaction.commit();
        this.f152a.run();
    }
}
