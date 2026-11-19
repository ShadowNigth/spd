.class Lnet/codestage/actk/androidnative/NativeUtils;
.super Ljava/lang/Object;
.source "NativeUtils.java"


# static fields
.field static LogTag:Ljava/lang/String;

.field private static applicationContext:Landroid/content/Context;

.field private static final hexArray:[C


# direct methods
.method static constructor <clinit>()V
    .locals 1

    .prologue
    .line 13
    const-string v0, "ACTk"

    sput-object v0, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    .line 17
    const/16 v0, 0x10

    new-array v0, v0, [C

    fill-array-data v0, :array_0

    sput-object v0, Lnet/codestage/actk/androidnative/NativeUtils;->hexArray:[C

    return-void

    :array_0
    .array-data 2
        0x30s
        0x31s
        0x32s
        0x33s
        0x34s
        0x35s
        0x36s
        0x37s
        0x38s
        0x39s
        0x41s
        0x42s
        0x43s
        0x44s
        0x45s
        0x46s
    .end array-data
.end method

.method constructor <init>()V
    .locals 0

    .prologue
    .line 11
    invoke-direct {p0}, Ljava/lang/Object;-><init>()V

    return-void
.end method

.method static BytesToHex([B)Ljava/lang/String;
    .locals 6
    .param p0, "bytes"    # [B

    .prologue
    .line 21
    array-length v3, p0

    mul-int/lit8 v3, v3, 0x2

    new-array v0, v3, [C

    .line 22
    .local v0, "hexChars":[C
    const/4 v1, 0x0

    .local v1, "j":I
    :goto_0
    array-length v3, p0

    if-ge v1, v3, :cond_0

    .line 23
    aget-byte v3, p0, v1

    xor-int/lit16 v3, v3, 0x90

    and-int/lit16 v2, v3, 0xff

    .line 24
    .local v2, "v":I
    mul-int/lit8 v3, v1, 0x2

    sget-object v4, Lnet/codestage/actk/androidnative/NativeUtils;->hexArray:[C

    ushr-int/lit8 v5, v2, 0x4

    aget-char v4, v4, v5

    aput-char v4, v0, v3

    .line 25
    mul-int/lit8 v3, v1, 0x2

    add-int/lit8 v3, v3, 0x1

    sget-object v4, Lnet/codestage/actk/androidnative/NativeUtils;->hexArray:[C

    and-int/lit8 v5, v2, 0xf

    aget-char v4, v4, v5

    aput-char v4, v0, v3

    .line 22
    add-int/lit8 v1, v1, 0x1

    goto :goto_0

    .line 27
    .end local v2    # "v":I
    :cond_0
    new-instance v3, Ljava/lang/String;

    invoke-direct {v3, v0}, Ljava/lang/String;-><init>([C)V

    return-object v3
.end method

.method static ContainsIgnoreCase(Ljava/lang/String;Ljava/lang/String;)Z
    .locals 2
    .param p0, "str"    # Ljava/lang/String;
    .param p1, "subString"    # Ljava/lang/String;

    .prologue
    .line 66
    if-eqz p0, :cond_0

    if-nez p1, :cond_1

    .line 67
    :cond_0
    const/4 v0, 0x0

    .line 69
    :goto_0
    return v0

    :cond_1
    invoke-virtual {p0}, Ljava/lang/String;->toLowerCase()Ljava/lang/String;

    move-result-object v0

    invoke-virtual {p1}, Ljava/lang/String;->toLowerCase()Ljava/lang/String;

    move-result-object v1

    invoke-virtual {v0, v1}, Ljava/lang/String;->contains(Ljava/lang/CharSequence;)Z

    move-result v0

    goto :goto_0
.end method

.method static GetApkPath()Ljava/lang/String;
    .locals 6
    .annotation system Ldalvik/annotation/Throws;
        value = {
            Landroid/content/pm/PackageManager$NameNotFoundException;,
            Ljava/lang/IllegalAccessException;,
            Ljava/lang/NoSuchFieldException;,
            Ljava/lang/ClassNotFoundException;
        }
    .end annotation

    .prologue
    const/4 v3, 0x0

    .line 32
    invoke-static {}, Lnet/codestage/actk/androidnative/NativeUtils;->GetUnityPlayerActivityIfNeeded()V

    .line 34
    sget-object v4, Lnet/codestage/actk/androidnative/NativeUtils;->applicationContext:Landroid/content/Context;

    if-nez v4, :cond_0

    .line 36
    sget-object v4, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v5, "[CodeHashGenerator ERROR] Couldn\'t get Unity context!"

    invoke-static {v4, v5}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    .line 61
    .local v1, "packageName":Ljava/lang/String;
    :goto_0
    return-object v3

    .line 40
    .end local v1    # "packageName":Ljava/lang/String;
    :cond_0
    sget-object v4, Lnet/codestage/actk/androidnative/NativeUtils;->applicationContext:Landroid/content/Context;

    invoke-virtual {v4}, Landroid/content/Context;->getPackageName()Ljava/lang/String;

    move-result-object v1

    .line 41
    .restart local v1    # "packageName":Ljava/lang/String;
    if-nez v1, :cond_1

    .line 43
    sget-object v4, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v5, "[CodeHashGenerator ERROR] Couldn\'t get package name!"

    invoke-static {v4, v5}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    goto :goto_0

    .line 47
    :cond_1
    sget-object v4, Lnet/codestage/actk/androidnative/NativeUtils;->applicationContext:Landroid/content/Context;

    invoke-virtual {v4}, Landroid/content/Context;->getPackageManager()Landroid/content/pm/PackageManager;

    move-result-object v2

    .line 48
    .local v2, "pm":Landroid/content/pm/PackageManager;
    if-nez v2, :cond_2

    .line 50
    sget-object v4, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v5, "[CodeHashGenerator ERROR] Couldn\'t get package manager!"

    invoke-static {v4, v5}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    goto :goto_0

    .line 54
    :cond_2
    const/4 v4, 0x0

    invoke-virtual {v2, v1, v4}, Landroid/content/pm/PackageManager;->getApplicationInfo(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;

    move-result-object v0

    .line 55
    .local v0, "ai":Landroid/content/pm/ApplicationInfo;
    if-nez v0, :cond_3

    .line 57
    sget-object v4, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v5, "[CodeHashGenerator ERROR] Couldn\'t get ApplicationInfo!"

    invoke-static {v4, v5}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    goto :goto_0

    .line 61
    :cond_3
    iget-object v3, v0, Landroid/content/pm/ApplicationInfo;->publicSourceDir:Ljava/lang/String;

    goto :goto_0
.end method

.method private static GetUnityPlayerActivityIfNeeded()V
    .locals 5
    .annotation system Ldalvik/annotation/Throws;
        value = {
            Ljava/lang/ClassNotFoundException;,
            Ljava/lang/NoSuchFieldException;,
            Ljava/lang/IllegalAccessException;
        }
    .end annotation

    .prologue
    .line 74
    sget-object v3, Lnet/codestage/actk/androidnative/NativeUtils;->applicationContext:Landroid/content/Context;

    if-eqz v3, :cond_0

    .line 99
    .local v2, "unityPlayerClass":Ljava/lang/Class;, "Ljava/lang/Class<*>;"
    :goto_0
    return-void

    .line 77
    .end local v2    # "unityPlayerClass":Ljava/lang/Class;, "Ljava/lang/Class<*>;"
    :cond_0
    const-string v3, "com.unity3d.player.UnityPlayer"

    invoke-static {v3}, Ljava/lang/Class;->forName(Ljava/lang/String;)Ljava/lang/Class;

    move-result-object v2

    .line 78
    .restart local v2    # "unityPlayerClass":Ljava/lang/Class;, "Ljava/lang/Class<*>;"
    if-nez v2, :cond_1

    .line 80
    sget-object v3, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v4, "[CodeHashGenerator ERROR] Couldn\'t get com.unity3d.player.UnityPlayer class!"

    invoke-static {v3, v4}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    goto :goto_0

    .line 84
    :cond_1
    const-string v3, "currentActivity"

    invoke-virtual {v2, v3}, Ljava/lang/Class;->getDeclaredField(Ljava/lang/String;)Ljava/lang/reflect/Field;

    move-result-object v0

    .line 85
    .local v0, "field":Ljava/lang/reflect/Field;
    if-nez v0, :cond_2

    .line 87
    sget-object v3, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v4, "[CodeHashGenerator ERROR] Couldn\'t get com.unity3d.player.UnityPlayer:currentActivity field!"

    invoke-static {v3, v4}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    goto :goto_0

    .line 91
    :cond_2
    const/4 v3, 0x0

    invoke-virtual {v0, v3}, Ljava/lang/reflect/Field;->get(Ljava/lang/Object;)Ljava/lang/Object;

    move-result-object v1

    check-cast v1, Landroid/app/Activity;

    .line 92
    .local v1, "unityPlayerActivity":Landroid/app/Activity;
    if-nez v1, :cond_3

    .line 94
    sget-object v3, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v4, "[CodeHashGenerator ERROR] Couldn\'t get Activity from com.unity3d.player.UnityPlayer:currentActivity field!"

    invoke-static {v3, v4}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    goto :goto_0

    .line 98
    :cond_3
    invoke-virtual {v1}, Landroid/app/Activity;->getApplicationContext()Landroid/content/Context;

    move-result-object v3

    sput-object v3, Lnet/codestage/actk/androidnative/NativeUtils;->applicationContext:Landroid/content/Context;

    goto :goto_0
.end method
