package com.unity3d.player;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.ColorDrawable;
import android.graphics.drawable.Drawable;
import android.graphics.drawable.LayerDrawable;
import android.view.View;
import net.codestage.actk.androidnative.BuildConfig;
/* renamed from: com.unity3d.player.j */
/* loaded from: classes.dex */
public final class C0056j extends View {

    /* renamed from: a */
    final int f166a;

    /* renamed from: b */
    final int f167b;

    /* renamed from: c */
    Bitmap f168c;

    /* renamed from: d */
    Bitmap f169d;

    /* renamed from: com.unity3d.player.j$1 */
    /* loaded from: classes.dex */
    static /* synthetic */ class C00571 {

        /* renamed from: a */
        static final /* synthetic */ int[] f170a = new int[EnumC0058a.m43a().length];

        static {
            try {
                f170a[EnumC0058a.f171a - 1] = 1;
            } catch (NoSuchFieldError e) {
            }
            try {
                f170a[EnumC0058a.f172b - 1] = 2;
            } catch (NoSuchFieldError e2) {
            }
            try {
                f170a[EnumC0058a.f173c - 1] = 3;
            } catch (NoSuchFieldError e3) {
            }
        }
    }

    /* JADX WARN: $VALUES field not found */
    /* JADX WARN: Failed to restore enum class, 'enum' modifier and super class removed */
    /* renamed from: com.unity3d.player.j$a */
    /* loaded from: classes.dex */
    static final class EnumC0058a {

        /* renamed from: a */
        public static final int f171a = 1;

        /* renamed from: b */
        public static final int f172b = 2;

        /* renamed from: c */
        public static final int f173c = 3;

        /* renamed from: d */
        private static final /* synthetic */ int[] f174d = {f171a, f172b, f173c};

        /* renamed from: a */
        public static int[] m43a() {
            return (int[]) f174d.clone();
        }
    }

    public C0056j(Context context, int i) {
        super(context);
        this.f166a = i;
        this.f167b = getResources().getIdentifier("unity_static_splash", "drawable", getContext().getPackageName());
        if (this.f167b != 0) {
            forceLayout();
        }
    }

    @Override // android.view.View
    public final void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        if (this.f168c != null) {
            this.f168c.recycle();
            this.f168c = null;
        }
        if (this.f169d != null) {
            this.f169d.recycle();
            this.f169d = null;
        }
    }

    @Override // android.view.View
    public final void onLayout(boolean z, int i, int i2, int i3, int i4) {
        int i5;
        int i6;
        if (this.f167b == 0) {
            return;
        }
        if (this.f168c == null) {
            BitmapFactory.Options options = new BitmapFactory.Options();
            options.inScaled = false;
            this.f168c = BitmapFactory.decodeResource(getResources(), this.f167b, options);
        }
        int width = this.f168c.getWidth();
        int height = this.f168c.getHeight();
        int width2 = getWidth();
        int height2 = getHeight();
        if (width2 == 0 || height2 == 0) {
            return;
        }
        float f = width / height;
        boolean z2 = ((float) width2) / ((float) height2) <= f;
        switch (C00571.f170a[this.f166a - 1]) {
            case BuildConfig.VERSION_CODE /* 1 */:
                if (width2 < width) {
                    i5 = (int) (width2 / f);
                } else {
                    i5 = height;
                    width2 = width;
                }
                if (height2 >= i5) {
                    i6 = width2;
                    break;
                } else {
                    i5 = height2;
                    i6 = (int) (i5 * f);
                    break;
                }
            case 2:
            case 3:
                if (!(z2 ^ (this.f166a == EnumC0058a.f173c))) {
                    i5 = height2;
                    i6 = (int) (i5 * f);
                    break;
                } else {
                    i5 = (int) (width2 / f);
                    i6 = width2;
                    break;
                }
            default:
                i5 = height;
                i6 = width;
                break;
        }
        if (this.f169d != null) {
            if (this.f169d.getWidth() == i6 && this.f169d.getHeight() == i5) {
                return;
            }
            if (this.f169d != this.f168c) {
                this.f169d.recycle();
                this.f169d = null;
            }
        }
        this.f169d = Bitmap.createScaledBitmap(this.f168c, i6, i5, true);
        this.f169d.setDensity(getResources().getDisplayMetrics().densityDpi);
        ColorDrawable colorDrawable = new ColorDrawable(-16777216);
        BitmapDrawable bitmapDrawable = new BitmapDrawable(getResources(), this.f169d);
        bitmapDrawable.setGravity(17);
        setBackground(new LayerDrawable(new Drawable[]{colorDrawable, bitmapDrawable}));
    }
}
