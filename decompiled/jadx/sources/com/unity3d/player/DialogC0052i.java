package com.unity3d.player;

import android.app.Dialog;
import android.content.Context;
import android.graphics.drawable.ColorDrawable;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.KeyEvent;
import android.view.View;
import android.view.ViewGroup;
import android.view.inputmethod.InputMethodManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RelativeLayout;
import android.widget.TextView;
/* renamed from: com.unity3d.player.i */
/* loaded from: classes.dex */
public final class DialogC0052i extends Dialog implements TextWatcher, View.OnClickListener {

    /* renamed from: c */
    private static int f157c = 1627389952;

    /* renamed from: d */
    private static int f158d = -1;

    /* renamed from: e */
    private static int f159e = 134217728;

    /* renamed from: f */
    private static int f160f = 67108864;

    /* renamed from: a */
    private Context f161a;

    /* renamed from: b */
    private UnityPlayer f162b;

    public DialogC0052i(Context context, UnityPlayer unityPlayer, String str, int i, boolean z, boolean z2, boolean z3, String str2) {
        super(context);
        this.f161a = null;
        this.f162b = null;
        this.f161a = context;
        this.f162b = unityPlayer;
        getWindow().setGravity(80);
        getWindow().requestFeature(1);
        getWindow().setBackgroundDrawable(new ColorDrawable(0));
        setContentView(createSoftInputView());
        getWindow().setLayout(-1, -2);
        getWindow().clearFlags(2);
        if (C0051h.f153a) {
            getWindow().clearFlags(f159e);
            getWindow().clearFlags(f160f);
        }
        EditText editText = (EditText) findViewById(1057292289);
        m49a(editText, str, i, z, z2, z3, str2);
        ((Button) findViewById(1057292290)).setOnClickListener(this);
        editText.setOnFocusChangeListener(new View.OnFocusChangeListener() { // from class: com.unity3d.player.i.1
            @Override // android.view.View.OnFocusChangeListener
            public final void onFocusChange(View view, boolean z4) {
                if (z4) {
                    DialogC0052i.this.getWindow().setSoftInputMode(5);
                }
            }
        });
        editText.requestFocus();
    }

    /* renamed from: a */
    private static int m50a(int i, boolean z, boolean z2, boolean z3) {
        int i2 = (z3 ? 128 : 0) | (z2 ? 131072 : 0) | (z ? 32768 : 524288);
        if (i < 0 || i > 10) {
            return i2;
        }
        int[] iArr = {1, 16385, 12290, 17, 2, 3, 8289, 33, 1, 16417, 17};
        return (iArr[i] & 2) != 0 ? iArr[i] : i2 | iArr[i];
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: a */
    public String m51a() {
        EditText editText = (EditText) findViewById(1057292289);
        if (editText == null) {
            return null;
        }
        return editText.getText().toString().trim();
    }

    /* renamed from: a */
    private void m49a(EditText editText, String str, int i, boolean z, boolean z2, boolean z3, String str2) {
        editText.setImeOptions(6);
        editText.setText(str);
        editText.setHint(str2);
        editText.setHintTextColor(f157c);
        editText.setInputType(m50a(i, z, z2, z3));
        editText.setImeOptions(33554432);
        editText.addTextChangedListener(this);
        editText.setClickable(true);
        if (z2) {
            return;
        }
        editText.selectAll();
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* renamed from: a */
    public void m45a(String str, boolean z) {
        ((EditText) findViewById(1057292289)).setSelection(0, 0);
        this.f162b.reportSoftInputStr(str, 1, z);
    }

    /* renamed from: a */
    public final void m46a(String str) {
        EditText editText = (EditText) findViewById(1057292289);
        if (editText != null) {
            editText.setText(str);
            editText.setSelection(str.length());
        }
    }

    @Override // android.text.TextWatcher
    public final void afterTextChanged(Editable editable) {
        this.f162b.reportSoftInputStr(editable.toString(), 0, false);
    }

    @Override // android.text.TextWatcher
    public final void beforeTextChanged(CharSequence charSequence, int i, int i2, int i3) {
    }

    protected final View createSoftInputView() {
        RelativeLayout relativeLayout = new RelativeLayout(this.f161a);
        relativeLayout.setLayoutParams(new ViewGroup.LayoutParams(-1, -1));
        relativeLayout.setBackgroundColor(f158d);
        EditText editText = new EditText(this.f161a) { // from class: com.unity3d.player.i.2
            @Override // android.widget.TextView, android.view.View
            public final boolean onKeyPreIme(int i, KeyEvent keyEvent) {
                if (i == 4) {
                    DialogC0052i.this.m45a(DialogC0052i.this.m51a(), true);
                    return true;
                } else if (i != 84) {
                    return super.onKeyPreIme(i, keyEvent);
                } else {
                    return true;
                }
            }

            @Override // android.widget.TextView, android.view.View
            public final void onWindowFocusChanged(boolean z) {
                super.onWindowFocusChanged(z);
                if (z) {
                    ((InputMethodManager) DialogC0052i.this.f161a.getSystemService("input_method")).showSoftInput(this, 0);
                }
            }
        };
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, -2);
        layoutParams.addRule(15);
        layoutParams.addRule(0, 1057292290);
        editText.setLayoutParams(layoutParams);
        editText.setId(1057292289);
        relativeLayout.addView(editText);
        Button button = new Button(this.f161a);
        button.setText(this.f161a.getResources().getIdentifier("ok", "string", "android"));
        RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(-2, -2);
        layoutParams2.addRule(15);
        layoutParams2.addRule(11);
        button.setLayoutParams(layoutParams2);
        button.setId(1057292290);
        button.setBackgroundColor(0);
        relativeLayout.addView(button);
        ((EditText) relativeLayout.findViewById(1057292289)).setOnEditorActionListener(new TextView.OnEditorActionListener() { // from class: com.unity3d.player.i.3
            @Override // android.widget.TextView.OnEditorActionListener
            public final boolean onEditorAction(TextView textView, int i, KeyEvent keyEvent) {
                if (i == 6) {
                    DialogC0052i.this.m45a(DialogC0052i.this.m51a(), false);
                }
                return false;
            }
        });
        relativeLayout.setPadding(16, 16, 16, 16);
        return relativeLayout;
    }

    @Override // android.app.Dialog
    public final void onBackPressed() {
        m45a(m51a(), true);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        m45a(m51a(), false);
    }

    @Override // android.text.TextWatcher
    public final void onTextChanged(CharSequence charSequence, int i, int i2, int i3) {
    }
}
