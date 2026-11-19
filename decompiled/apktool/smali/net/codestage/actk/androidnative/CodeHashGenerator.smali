.class public Lnet/codestage/actk/androidnative/CodeHashGenerator;
.super Ljava/lang/Object;
.source "CodeHashGenerator.java"


# annotations
.annotation system Ldalvik/annotation/MemberClasses;
    value = {
        Lnet/codestage/actk/androidnative/CodeHashGenerator$CodeHashCalculator;,
        Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;
    }
.end annotation


# static fields
.field private static lastCallback:Lnet/codestage/actk/androidnative/CodeHashCallback;


# direct methods
.method public constructor <init>()V
    .locals 0

    .prologue
    .line 20
    invoke-direct {p0}, Ljava/lang/Object;-><init>()V

    return-void
.end method

.method private static GetArrayHash(Ljava/security/MessageDigest;Ljava/util/List;)Ljava/lang/String;
    .locals 4
    .param p0, "digest"    # Ljava/security/MessageDigest;
    .annotation system Ldalvik/annotation/Signature;
        value = {
            "(",
            "Ljava/security/MessageDigest;",
            "Ljava/util/List",
            "<",
            "Ljava/lang/String;",
            ">;)",
            "Ljava/lang/String;"
        }
    .end annotation

    .prologue
    .line 279
    .local p1, "hashes":Ljava/util/List;, "Ljava/util/List<Ljava/lang/String;>;"
    invoke-static {p1}, Ljava/util/Collections;->sort(Ljava/util/List;)V

    .line 280
    const-string v3, ""

    invoke-static {v3, p1}, Landroid/text/TextUtils;->join(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;

    move-result-object v0

    .line 281
    .local v0, "allHashes":Ljava/lang/String;
    invoke-virtual {v0}, Ljava/lang/String;->getBytes()[B

    move-result-object v1

    .line 283
    .local v1, "allHashesBytes":[B
    invoke-virtual {p0, v1}, Ljava/security/MessageDigest;->update([B)V

    .line 284
    invoke-virtual {p0}, Ljava/security/MessageDigest;->digest()[B

    move-result-object v2

    .line 286
    .local v2, "hashBytes":[B
    invoke-static {v2}, Lnet/codestage/actk/androidnative/NativeUtils;->BytesToHex([B)Ljava/lang/String;

    move-result-object v3

    return-object v3
.end method

.method public static GetCodeHash([Ljava/lang/String;Lnet/codestage/actk/androidnative/CodeHashCallback;)V
    .locals 3
    .param p0, "fileFilters"    # [Ljava/lang/String;
    .param p1, "callback"    # Lnet/codestage/actk/androidnative/CodeHashCallback;

    .prologue
    .line 71
    sput-object p1, Lnet/codestage/actk/androidnative/CodeHashGenerator;->lastCallback:Lnet/codestage/actk/androidnative/CodeHashCallback;

    .line 72
    new-instance v0, Lnet/codestage/actk/androidnative/CodeHashGenerator$CodeHashCalculator;

    const/4 v1, 0x0

    invoke-direct {v0, v1}, Lnet/codestage/actk/androidnative/CodeHashGenerator$CodeHashCalculator;-><init>(Lnet/codestage/actk/androidnative/CodeHashGenerator$1;)V

    const/4 v1, 0x1

    new-array v1, v1, [[Ljava/lang/String;

    const/4 v2, 0x0

    aput-object p0, v1, v2

    invoke-virtual {v0, v1}, Lnet/codestage/actk/androidnative/CodeHashGenerator$CodeHashCalculator;->execute([Ljava/lang/Object;)Landroid/os/AsyncTask;

    .line 73
    return-void
.end method

.method private static GetCodeHashThread([Lnet/codestage/actk/androidnative/FileFilter;)Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;
    .locals 17
    .param p0, "fileFilters"    # [Lnet/codestage/actk/androidnative/FileFilter;
    .annotation system Ldalvik/annotation/Throws;
        value = {
            Ljava/lang/ClassNotFoundException;,
            Landroid/content/pm/PackageManager$NameNotFoundException;,
            Ljava/lang/NoSuchFieldException;,
            Ljava/lang/IllegalAccessException;,
            Ljava/io/IOException;,
            Ljava/security/NoSuchAlgorithmException;
        }
    .end annotation

    .prologue
    .line 77
    new-instance v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;

    const/4 v13, 0x0

    invoke-direct {v12, v13}, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;-><init>(Lnet/codestage/actk/androidnative/CodeHashGenerator$1;)V

    .line 81
    .local v12, "result":Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;
    invoke-static {}, Lnet/codestage/actk/androidnative/NativeUtils;->GetApkPath()Ljava/lang/String;

    move-result-object v5

    .line 83
    .local v5, "currentApkPath":Ljava/lang/String;
    if-nez v5, :cond_0

    .line 85
    const-string v13, "[CodeHashGenerator ERROR] Can\'t get APK path!"

    iput-object v13, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    .line 86
    sget-object v13, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    iget-object v14, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    invoke-static {v13, v14}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    .line 187
    :goto_0
    return-object v12

    .line 90
    :cond_0
    new-instance v2, Ljava/util/ArrayList;

    invoke-direct {v2}, Ljava/util/ArrayList;-><init>()V

    .line 92
    .local v2, "apkFiles":Ljava/util/List;, "Ljava/util/List<Ljava/lang/String;>;"
    new-instance v1, Ljava/io/File;

    invoke-direct {v1, v5}, Ljava/io/File;-><init>(Ljava/lang/String;)V

    .line 93
    .local v1, "apkFile":Ljava/io/File;
    invoke-virtual {v1}, Ljava/io/File;->exists()Z

    move-result v13

    if-nez v13, :cond_1

    .line 95
    new-instance v13, Ljava/lang/StringBuilder;

    invoke-direct {v13}, Ljava/lang/StringBuilder;-><init>()V

    const-string v14, "[CodeHashGenerator ERROR] Can\'t create file for APK path: "

    invoke-virtual {v13, v14}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v13

    invoke-virtual {v13, v5}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v13

    invoke-virtual {v13}, Ljava/lang/StringBuilder;->toString()Ljava/lang/String;

    move-result-object v13

    invoke-static {v13}, Lnet/codestage/actk/androidnative/ACTkErrors;->GetText(Ljava/lang/String;)Ljava/lang/String;

    move-result-object v13

    iput-object v13, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    .line 96
    sget-object v13, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    iget-object v14, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    invoke-static {v13, v14}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    goto :goto_0

    .line 100
    :cond_1
    invoke-virtual {v1}, Ljava/io/File;->getParentFile()Ljava/io/File;

    move-result-object v3

    .line 101
    .local v3, "apkFolder":Ljava/io/File;
    if-nez v3, :cond_2

    .line 103
    sget-object v13, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v14, "[CodeHashGenerator ERROR] Can\'t find parent folder of APK file at path: "

    invoke-static {v13, v14}, Landroid/util/Log;->w(Ljava/lang/String;Ljava/lang/String;)I

    .line 104
    invoke-interface {v2, v5}, Ljava/util/List;->add(Ljava/lang/Object;)Z

    .line 105
    iput-object v5, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->buildPath:Ljava/lang/String;

    .line 138
    :goto_1
    const-string v13, "SHA-1"

    invoke-static {v13}, Ljava/security/MessageDigest;->getInstance(Ljava/lang/String;)Ljava/security/MessageDigest;

    move-result-object v6

    .line 139
    .local v6, "digest":Ljava/security/MessageDigest;
    if-nez v6, :cond_8

    .line 141
    const-string v13, "[CodeHashGenerator ERROR] Can\'t get SHA-1 digest instance!"

    invoke-static {v13}, Lnet/codestage/actk/androidnative/ACTkErrors;->GetText(Ljava/lang/String;)Ljava/lang/String;

    move-result-object v13

    iput-object v13, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    .line 142
    sget-object v13, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    iget-object v14, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    invoke-static {v13, v14}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    goto :goto_0

    .line 109
    .end local v6    # "digest":Ljava/security/MessageDigest;
    :cond_2
    invoke-virtual {v3}, Ljava/io/File;->listFiles()[Ljava/io/File;

    move-result-object v8

    .line 110
    .local v8, "filesInApkFolder":[Ljava/io/File;
    if-eqz v8, :cond_3

    array-length v13, v8

    if-nez v13, :cond_4

    .line 112
    :cond_3
    sget-object v13, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v14, "[CodeHashGenerator ERROR] Can\'t get any files in APK folder at path: "

    invoke-static {v13, v14}, Landroid/util/Log;->w(Ljava/lang/String;Ljava/lang/String;)I

    .line 113
    invoke-interface {v2, v5}, Ljava/util/List;->add(Ljava/lang/Object;)Z

    .line 114
    iput-object v5, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->buildPath:Ljava/lang/String;

    goto :goto_1

    .line 118
    :cond_4
    array-length v14, v8

    const/4 v13, 0x0

    :goto_2
    if-ge v13, v14, :cond_7

    aget-object v7, v8, v13

    .line 120
    .local v7, "file":Ljava/io/File;
    invoke-virtual {v7}, Ljava/io/File;->getPath()Ljava/lang/String;

    move-result-object v4

    .line 123
    .local v4, "apkPath":Ljava/lang/String;
    const-string v15, ""

    invoke-virtual {v4, v15}, Ljava/lang/String;->equals(Ljava/lang/Object;)Z

    move-result v15

    if-eqz v15, :cond_6

    .line 125
    sget-object v15, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v16, "[CodeHashGenerator ERROR] Can\'t get path for file in APK folder!"

    invoke-static/range {v15 .. v16}, Landroid/util/Log;->w(Ljava/lang/String;Ljava/lang/String;)I

    .line 118
    :cond_5
    :goto_3
    add-int/lit8 v13, v13, 0x1

    goto :goto_2

    .line 129
    :cond_6
    invoke-virtual {v4}, Ljava/lang/String;->toLowerCase()Ljava/lang/String;

    move-result-object v15

    const-string v16, ".apk"

    invoke-virtual/range {v15 .. v16}, Ljava/lang/String;->endsWith(Ljava/lang/String;)Z

    move-result v15

    if-eqz v15, :cond_5

    .line 131
    invoke-interface {v2, v4}, Ljava/util/List;->add(Ljava/lang/Object;)Z

    goto :goto_3

    .line 134
    .end local v4    # "apkPath":Ljava/lang/String;
    .end local v7    # "file":Ljava/io/File;
    :cond_7
    iput-object v5, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->buildPath:Ljava/lang/String;

    goto :goto_1

    .line 146
    .end local v8    # "filesInApkFolder":[Ljava/io/File;
    .restart local v6    # "digest":Ljava/security/MessageDigest;
    :cond_8
    new-instance v11, Ljava/util/ArrayList;

    invoke-direct {v11}, Ljava/util/ArrayList;-><init>()V

    .line 147
    .local v11, "paths":Ljava/util/List;, "Ljava/util/List<Ljava/lang/String;>;"
    new-instance v9, Ljava/util/ArrayList;

    invoke-direct {v9}, Ljava/util/ArrayList;-><init>()V

    .line 149
    .local v9, "hashes":Ljava/util/List;, "Ljava/util/List<Ljava/lang/String;>;"
    invoke-interface {v2}, Ljava/util/List;->iterator()Ljava/util/Iterator;

    move-result-object v13

    :goto_4
    invoke-interface {v13}, Ljava/util/Iterator;->hasNext()Z

    move-result v14

    if-eqz v14, :cond_a

    invoke-interface {v13}, Ljava/util/Iterator;->next()Ljava/lang/Object;

    move-result-object v4

    check-cast v4, Ljava/lang/String;

    .line 153
    .restart local v4    # "apkPath":Ljava/lang/String;
    invoke-static {v4}, Lnet/codestage/actk/androidnative/CodeHashGenerator;->GetJarFromApk(Ljava/lang/String;)Ljava/util/jar/JarFile;

    move-result-object v10

    .line 154
    .local v10, "jar":Ljava/util/jar/JarFile;
    if-nez v10, :cond_9

    .line 156
    new-instance v13, Ljava/lang/StringBuilder;

    invoke-direct {v13}, Ljava/lang/StringBuilder;-><init>()V

    const-string v14, "[CodeHashGenerator ERROR] Can\'t read APK with path: "

    invoke-virtual {v13, v14}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v13

    invoke-virtual {v13, v4}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v13

    invoke-virtual {v13}, Ljava/lang/StringBuilder;->toString()Ljava/lang/String;

    move-result-object v13

    invoke-static {v13}, Lnet/codestage/actk/androidnative/ACTkErrors;->GetText(Ljava/lang/String;)Ljava/lang/String;

    move-result-object v13

    iput-object v13, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    .line 157
    sget-object v13, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    iget-object v14, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    invoke-static {v13, v14}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    goto/16 :goto_0

    .line 161
    :cond_9
    move-object/from16 v0, p0

    invoke-static {v6, v10, v0, v11, v9}, Lnet/codestage/actk/androidnative/CodeHashGenerator;->HashFiles(Ljava/security/MessageDigest;Ljava/util/jar/JarFile;[Lnet/codestage/actk/androidnative/FileFilter;Ljava/util/List;Ljava/util/List;)V

    goto :goto_4

    .line 164
    .end local v4    # "apkPath":Ljava/lang/String;
    .end local v10    # "jar":Ljava/util/jar/JarFile;
    :cond_a
    invoke-interface {v9}, Ljava/util/List;->size()I

    move-result v13

    if-nez v13, :cond_b

    .line 166
    const-string v13, "[CodeHashGenerator ERROR] Nothing to hash!"

    invoke-static {v13}, Lnet/codestage/actk/androidnative/ACTkErrors;->GetText(Ljava/lang/String;)Ljava/lang/String;

    move-result-object v13

    iput-object v13, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    .line 167
    sget-object v13, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    iget-object v14, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    invoke-static {v13, v14}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    goto/16 :goto_0

    .line 171
    :cond_b
    iput-object v5, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->buildPath:Ljava/lang/String;

    .line 172
    const/4 v13, 0x0

    new-array v13, v13, [Ljava/lang/String;

    invoke-interface {v9, v13}, Ljava/util/List;->toArray([Ljava/lang/Object;)[Ljava/lang/Object;

    move-result-object v13

    check-cast v13, [Ljava/lang/String;

    iput-object v13, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->hashes:[Ljava/lang/String;

    .line 173
    const/4 v13, 0x0

    new-array v13, v13, [Ljava/lang/String;

    invoke-interface {v11, v13}, Ljava/util/List;->toArray([Ljava/lang/Object;)[Ljava/lang/Object;

    move-result-object v13

    check-cast v13, [Ljava/lang/String;

    iput-object v13, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->paths:[Ljava/lang/String;

    .line 174
    invoke-static {v6, v9}, Lnet/codestage/actk/androidnative/CodeHashGenerator;->GetArrayHash(Ljava/security/MessageDigest;Ljava/util/List;)Ljava/lang/String;

    move-result-object v13

    iput-object v13, v12, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->summaryHash:Ljava/lang/String;

    goto/16 :goto_0
.end method

.method private static GetFiltersFromStrings([Ljava/lang/String;)[Lnet/codestage/actk/androidnative/FileFilter;
    .locals 4
    .param p0, "strings"    # [Ljava/lang/String;

    .prologue
    .line 291
    array-length v3, p0

    new-array v2, v3, [Lnet/codestage/actk/androidnative/FileFilter;

    .line 292
    .local v2, "result":[Lnet/codestage/actk/androidnative/FileFilter;
    const/4 v1, 0x0

    .local v1, "i":I
    :goto_0
    array-length v3, p0

    if-ge v1, v3, :cond_0

    .line 294
    aget-object v0, p0, v1

    .line 295
    .local v0, "filterString":Ljava/lang/String;
    new-instance v3, Lnet/codestage/actk/androidnative/FileFilter;

    invoke-direct {v3, v0}, Lnet/codestage/actk/androidnative/FileFilter;-><init>(Ljava/lang/String;)V

    aput-object v3, v2, v1

    .line 292
    add-int/lit8 v1, v1, 0x1

    goto :goto_0

    .line 298
    .end local v0    # "filterString":Ljava/lang/String;
    :cond_0
    return-object v2
.end method

.method private static GetJarFromApk(Ljava/lang/String;)Ljava/util/jar/JarFile;
    .locals 2
    .param p0, "apkPath"    # Ljava/lang/String;
    .annotation system Ldalvik/annotation/Throws;
        value = {
            Ljava/io/IOException;
        }
    .end annotation

    .prologue
    .line 194
    new-instance v0, Ljava/io/File;

    invoke-direct {v0, p0}, Ljava/io/File;-><init>(Ljava/lang/String;)V

    .line 195
    .local v0, "apkFile":Ljava/io/File;
    invoke-virtual {v0}, Ljava/io/File;->exists()Z

    move-result v1

    if-eqz v1, :cond_0

    .line 197
    new-instance v1, Ljava/util/jar/JarFile;

    invoke-direct {v1, p0}, Ljava/util/jar/JarFile;-><init>(Ljava/lang/String;)V

    .line 201
    :goto_0
    return-object v1

    :cond_0
    const/4 v1, 0x0

    goto :goto_0
.end method

.method private static HashFiles(Ljava/security/MessageDigest;Ljava/util/jar/JarFile;[Lnet/codestage/actk/androidnative/FileFilter;Ljava/util/List;Ljava/util/List;)V
    .locals 16
    .param p0, "digest"    # Ljava/security/MessageDigest;
    .param p1, "jar"    # Ljava/util/jar/JarFile;
    .param p2, "fileFilters"    # [Lnet/codestage/actk/androidnative/FileFilter;
    .annotation system Ldalvik/annotation/Signature;
        value = {
            "(",
            "Ljava/security/MessageDigest;",
            "Ljava/util/jar/JarFile;",
            "[",
            "Lnet/codestage/actk/androidnative/FileFilter;",
            "Ljava/util/List",
            "<",
            "Ljava/lang/String;",
            ">;",
            "Ljava/util/List",
            "<",
            "Ljava/lang/String;",
            ">;)V"
        }
    .end annotation

    .annotation system Ldalvik/annotation/Throws;
        value = {
            Ljava/io/IOException;
        }
    .end annotation

    .prologue
    .line 207
    .local p3, "paths":Ljava/util/List;, "Ljava/util/List<Ljava/lang/String;>;"
    .local p4, "hashes":Ljava/util/List;, "Ljava/util/List<Ljava/lang/String;>;"
    const/16 v12, 0x2000

    new-array v1, v12, [B

    .line 209
    .local v1, "buffer":[B
    invoke-virtual/range {p1 .. p1}, Ljava/util/jar/JarFile;->entries()Ljava/util/Enumeration;

    move-result-object v3

    .line 210
    .local v3, "entries":Ljava/util/Enumeration;, "Ljava/util/Enumeration<Ljava/util/jar/JarEntry;>;"
    if-nez v3, :cond_1

    .line 212
    sget-object v12, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v13, "[CodeHashGenerator ERROR] Nothing found in APK JAR!"

    invoke-static {v12, v13}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    .line 275
    :cond_0
    return-void

    .line 216
    :cond_1
    invoke-static {v3}, Ljava/util/Collections;->list(Ljava/util/Enumeration;)Ljava/util/ArrayList;

    move-result-object v4

    .line 217
    .local v4, "entriesList":Ljava/util/List;, "Ljava/util/List<Ljava/util/jar/JarEntry;>;"
    invoke-interface {v4}, Ljava/util/List;->iterator()Ljava/util/Iterator;

    move-result-object v13

    :cond_2
    :goto_0
    invoke-interface {v13}, Ljava/util/Iterator;->hasNext()Z

    move-result v12

    if-eqz v12, :cond_0

    invoke-interface {v13}, Ljava/util/Iterator;->next()Ljava/lang/Object;

    move-result-object v5

    check-cast v5, Ljava/util/jar/JarEntry;

    .line 219
    .local v5, "entry":Ljava/util/jar/JarEntry;
    if-nez v5, :cond_3

    .line 221
    sget-object v12, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v14, "[CodeHashGenerator ERROR] Some JAR entry is null!"

    invoke-static {v12, v14}, Landroid/util/Log;->w(Ljava/lang/String;Ljava/lang/String;)I

    goto :goto_0

    .line 226
    :cond_3
    invoke-virtual {v5}, Ljava/util/jar/JarEntry;->getName()Ljava/lang/String;

    move-result-object v6

    .line 228
    .local v6, "entryPath":Ljava/lang/String;
    if-nez v6, :cond_4

    .line 230
    sget-object v12, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v14, "[CodeHashGenerator ERROR] Some JAR entry has null path!"

    invoke-static {v12, v14}, Landroid/util/Log;->w(Ljava/lang/String;Ljava/lang/String;)I

    goto :goto_0

    .line 234
    :cond_4
    const/4 v11, 0x0

    .line 235
    .local v11, "suitableFile":Z
    move-object/from16 v0, p2

    array-length v14, v0

    const/4 v12, 0x0

    :goto_1
    if-ge v12, v14, :cond_5

    aget-object v8, p2, v12

    .line 237
    .local v8, "fileFilter":Lnet/codestage/actk/androidnative/FileFilter;
    invoke-virtual {v8, v6}, Lnet/codestage/actk/androidnative/FileFilter;->MatchPath(Ljava/lang/String;)Z

    move-result v15

    if-eqz v15, :cond_6

    .line 239
    const/4 v11, 0x1

    .line 244
    .end local v8    # "fileFilter":Lnet/codestage/actk/androidnative/FileFilter;
    :cond_5
    if-eqz v11, :cond_2

    .line 246
    move-object/from16 v0, p1

    invoke-virtual {v0, v5}, Ljava/util/jar/JarFile;->getInputStream(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;

    move-result-object v9

    .line 248
    .local v9, "is":Ljava/io/InputStream;
    if-nez v9, :cond_7

    .line 250
    sget-object v12, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    new-instance v14, Ljava/lang/StringBuilder;

    invoke-direct {v14}, Ljava/lang/StringBuilder;-><init>()V

    const-string v15, "[CodeHashGenerator ERROR] JAR has null input stream for entry with path: "

    invoke-virtual {v14, v15}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v14

    invoke-virtual {v14, v6}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v14

    invoke-virtual {v14}, Ljava/lang/StringBuilder;->toString()Ljava/lang/String;

    move-result-object v14

    invoke-static {v12, v14}, Landroid/util/Log;->w(Ljava/lang/String;Ljava/lang/String;)I

    goto :goto_0

    .line 235
    .end local v9    # "is":Ljava/io/InputStream;
    .restart local v8    # "fileFilter":Lnet/codestage/actk/androidnative/FileFilter;
    :cond_6
    add-int/lit8 v12, v12, 0x1

    goto :goto_1

    .line 254
    .end local v8    # "fileFilter":Lnet/codestage/actk/androidnative/FileFilter;
    .restart local v9    # "is":Ljava/io/InputStream;
    :cond_7
    const/4 v10, 0x0

    .line 255
    .local v10, "n":I
    :cond_8
    :goto_2
    const/4 v12, -0x1

    if-eq v10, v12, :cond_9

    .line 257
    invoke-virtual {v9, v1}, Ljava/io/InputStream;->read([B)I

    move-result v10

    .line 258
    if-lez v10, :cond_8

    .line 260
    const/4 v12, 0x0

    move-object/from16 v0, p0

    invoke-virtual {v0, v1, v12, v10}, Ljava/security/MessageDigest;->update([BII)V

    goto :goto_2

    .line 264
    :cond_9
    invoke-virtual/range {p0 .. p0}, Ljava/security/MessageDigest;->digest()[B

    move-result-object v7

    .line 265
    .local v7, "fileDigest":[B
    invoke-static {v7}, Lnet/codestage/actk/androidnative/NativeUtils;->BytesToHex([B)Ljava/lang/String;

    move-result-object v2

    .line 267
    .local v2, "digestString":Ljava/lang/String;
    move-object/from16 v0, p3

    invoke-interface {v0, v6}, Ljava/util/List;->add(Ljava/lang/Object;)Z

    .line 268
    move-object/from16 v0, p4

    invoke-interface {v0, v2}, Ljava/util/List;->add(Ljava/lang/Object;)Z

    .line 272
    invoke-virtual/range {p0 .. p0}, Ljava/security/MessageDigest;->reset()V

    .line 273
    invoke-virtual {v9}, Ljava/io/InputStream;->close()V

    goto/16 :goto_0
.end method

.method static synthetic access$000([Ljava/lang/String;)[Lnet/codestage/actk/androidnative/FileFilter;
    .locals 1
    .param p0, "x0"    # [Ljava/lang/String;

    .prologue
    .line 20
    invoke-static {p0}, Lnet/codestage/actk/androidnative/CodeHashGenerator;->GetFiltersFromStrings([Ljava/lang/String;)[Lnet/codestage/actk/androidnative/FileFilter;

    move-result-object v0

    return-object v0
.end method

.method static synthetic access$100([Lnet/codestage/actk/androidnative/FileFilter;)Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;
    .locals 1
    .param p0, "x0"    # [Lnet/codestage/actk/androidnative/FileFilter;
    .annotation system Ldalvik/annotation/Throws;
        value = {
            Ljava/lang/ClassNotFoundException;,
            Landroid/content/pm/PackageManager$NameNotFoundException;,
            Ljava/lang/NoSuchFieldException;,
            Ljava/lang/IllegalAccessException;,
            Ljava/io/IOException;,
            Ljava/security/NoSuchAlgorithmException;
        }
    .end annotation

    .prologue
    .line 20
    invoke-static {p0}, Lnet/codestage/actk/androidnative/CodeHashGenerator;->GetCodeHashThread([Lnet/codestage/actk/androidnative/FileFilter;)Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;

    move-result-object v0

    return-object v0
.end method

.method static synthetic access$300()Lnet/codestage/actk/androidnative/CodeHashCallback;
    .locals 1

    .prologue
    .line 20
    sget-object v0, Lnet/codestage/actk/androidnative/CodeHashGenerator;->lastCallback:Lnet/codestage/actk/androidnative/CodeHashCallback;

    return-object v0
.end method
