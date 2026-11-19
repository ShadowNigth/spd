.class Lnet/codestage/actk/androidnative/FileFilter;
.super Ljava/lang/Object;
.source "FileFilter.java"


# instance fields
.field private caseSensitive:Ljava/lang/Boolean;

.field private exactFileNameMatch:Ljava/lang/Boolean;

.field private exactFolderMatch:Ljava/lang/Boolean;

.field private filterExtension:Ljava/lang/String;

.field private filterFileName:Ljava/lang/String;

.field private filterFolder:Ljava/lang/String;

.field private folderRecursive:Ljava/lang/Boolean;


# direct methods
.method constructor <init>(Ljava/lang/String;)V
    .locals 5
    .param p1, "filterString"    # Ljava/lang/String;

    .prologue
    const/4 v4, 0x6

    const/4 v3, 0x5

    const/4 v2, 0x4

    .line 18
    invoke-direct {p0}, Ljava/lang/Object;-><init>()V

    .line 19
    if-eqz p1, :cond_0

    invoke-virtual {p1}, Ljava/lang/String;->isEmpty()Z

    move-result v1

    if-eqz v1, :cond_2

    .line 21
    :cond_0
    sget-object v1, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    const-string v2, "Can\'t parse FileFilter: string is null or empty!"

    invoke-static {v1, v2}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    .line 59
    :cond_1
    :goto_0
    return-void

    .line 27
    :cond_2
    const-string v1, "\\|"

    invoke-virtual {p1, v1}, Ljava/lang/String;->split(Ljava/lang/String;)[Ljava/lang/String;

    move-result-object v0

    .line 34
    .local v0, "items":[Ljava/lang/String;
    array-length v1, v0

    if-ge v1, v2, :cond_3

    .line 36
    sget-object v1, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    new-instance v2, Ljava/lang/StringBuilder;

    invoke-direct {v2}, Ljava/lang/StringBuilder;-><init>()V

    const-string v3, "Can\'t parse FileFilter: string split only to "

    invoke-virtual {v2, v3}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v2

    array-length v3, v0

    invoke-virtual {v2, v3}, Ljava/lang/StringBuilder;->append(I)Ljava/lang/StringBuilder;

    move-result-object v2

    const-string v3, " parts instead of minimum 4 parts!"

    invoke-virtual {v2, v3}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v2

    invoke-virtual {v2}, Ljava/lang/StringBuilder;->toString()Ljava/lang/String;

    move-result-object v2

    invoke-static {v1, v2}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;)I

    goto :goto_0

    .line 40
    :cond_3
    const/4 v1, 0x0

    aget-object v1, v0, v1

    invoke-static {v1}, Ljava/lang/Boolean;->parseBoolean(Ljava/lang/String;)Z

    move-result v1

    invoke-static {v1}, Ljava/lang/Boolean;->valueOf(Z)Ljava/lang/Boolean;

    move-result-object v1

    iput-object v1, p0, Lnet/codestage/actk/androidnative/FileFilter;->caseSensitive:Ljava/lang/Boolean;

    .line 41
    const/4 v1, 0x1

    aget-object v1, v0, v1

    invoke-static {v1}, Ljava/lang/Boolean;->parseBoolean(Ljava/lang/String;)Z

    move-result v1

    invoke-static {v1}, Ljava/lang/Boolean;->valueOf(Z)Ljava/lang/Boolean;

    move-result-object v1

    iput-object v1, p0, Lnet/codestage/actk/androidnative/FileFilter;->folderRecursive:Ljava/lang/Boolean;

    .line 42
    const/4 v1, 0x2

    aget-object v1, v0, v1

    invoke-static {v1}, Ljava/lang/Boolean;->parseBoolean(Ljava/lang/String;)Z

    move-result v1

    invoke-static {v1}, Ljava/lang/Boolean;->valueOf(Z)Ljava/lang/Boolean;

    move-result-object v1

    iput-object v1, p0, Lnet/codestage/actk/androidnative/FileFilter;->exactFileNameMatch:Ljava/lang/Boolean;

    .line 43
    const/4 v1, 0x3

    aget-object v1, v0, v1

    invoke-static {v1}, Ljava/lang/Boolean;->parseBoolean(Ljava/lang/String;)Z

    move-result v1

    invoke-static {v1}, Ljava/lang/Boolean;->valueOf(Z)Ljava/lang/Boolean;

    move-result-object v1

    iput-object v1, p0, Lnet/codestage/actk/androidnative/FileFilter;->exactFolderMatch:Ljava/lang/Boolean;

    .line 45
    array-length v1, v0

    if-lt v1, v3, :cond_4

    .line 47
    aget-object v1, v0, v2

    iput-object v1, p0, Lnet/codestage/actk/androidnative/FileFilter;->filterFolder:Ljava/lang/String;

    .line 50
    :cond_4
    array-length v1, v0

    if-lt v1, v4, :cond_5

    .line 52
    aget-object v1, v0, v3

    iput-object v1, p0, Lnet/codestage/actk/androidnative/FileFilter;->filterExtension:Ljava/lang/String;

    .line 55
    :cond_5
    array-length v1, v0

    const/4 v2, 0x7

    if-lt v1, v2, :cond_1

    .line 57
    aget-object v1, v0, v4

    iput-object v1, p0, Lnet/codestage/actk/androidnative/FileFilter;->filterFileName:Ljava/lang/String;

    goto :goto_0
.end method


# virtual methods
.method MatchPath(Ljava/lang/String;)Z
    .locals 6
    .param p1, "path"    # Ljava/lang/String;

    .prologue
    const/4 v4, 0x0

    .line 63
    new-instance v2, Ljava/io/File;

    invoke-direct {v2, p1}, Ljava/io/File;-><init>(Ljava/lang/String;)V

    .line 65
    .local v2, "filePath":Ljava/io/File;
    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->filterExtension:Ljava/lang/String;

    if-eqz v5, :cond_2

    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->filterExtension:Ljava/lang/String;

    invoke-virtual {v5}, Ljava/lang/String;->isEmpty()Z

    move-result v5

    if-nez v5, :cond_2

    .line 67
    invoke-virtual {v2}, Ljava/io/File;->getName()Ljava/lang/String;

    move-result-object v0

    .line 68
    .local v0, "extension":Ljava/lang/String;
    invoke-virtual {v0}, Ljava/lang/String;->isEmpty()Z

    move-result v5

    if-eqz v5, :cond_1

    .line 161
    .end local v0    # "extension":Ljava/lang/String;
    :cond_0
    :goto_0
    return v4

    .line 74
    .restart local v0    # "extension":Ljava/lang/String;
    :cond_1
    const-string v5, "."

    invoke-virtual {v0, v5}, Ljava/lang/String;->indexOf(Ljava/lang/String;)I

    move-result v5

    if-lez v5, :cond_0

    .line 76
    const-string v5, "."

    invoke-virtual {v0, v5}, Ljava/lang/String;->lastIndexOf(Ljava/lang/String;)I

    move-result v3

    .line 77
    .local v3, "index":I
    add-int/lit8 v5, v3, 0x1

    invoke-virtual {v0, v5}, Ljava/lang/String;->substring(I)Ljava/lang/String;

    move-result-object v0

    .line 84
    invoke-virtual {v0}, Ljava/lang/String;->isEmpty()Z

    move-result v5

    if-nez v5, :cond_0

    .line 89
    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->caseSensitive:Ljava/lang/Boolean;

    invoke-virtual {v5}, Ljava/lang/Boolean;->booleanValue()Z

    move-result v5

    if-eqz v5, :cond_5

    .line 91
    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->filterExtension:Ljava/lang/String;

    invoke-virtual {v5, v0}, Ljava/lang/String;->equals(Ljava/lang/Object;)Z

    move-result v5

    if-eqz v5, :cond_0

    .line 105
    .end local v0    # "extension":Ljava/lang/String;
    .end local v3    # "index":I
    :cond_2
    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->filterFileName:Ljava/lang/String;

    if-eqz v5, :cond_4

    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->filterFileName:Ljava/lang/String;

    invoke-virtual {v5}, Ljava/lang/String;->isEmpty()Z

    move-result v5

    if-nez v5, :cond_4

    .line 107
    invoke-virtual {v2}, Ljava/io/File;->getName()Ljava/lang/String;

    move-result-object v1

    .line 109
    .local v1, "fileName":Ljava/lang/String;
    invoke-virtual {v1}, Ljava/lang/String;->isEmpty()Z

    move-result v5

    if-nez v5, :cond_0

    .line 115
    const-string v5, "."

    invoke-virtual {v1, v5}, Ljava/lang/String;->indexOf(Ljava/lang/String;)I

    move-result v5

    if-lez v5, :cond_3

    .line 117
    const-string v5, "."

    invoke-virtual {v1, v5}, Ljava/lang/String;->lastIndexOf(Ljava/lang/String;)I

    move-result v5

    invoke-virtual {v1, v4, v5}, Ljava/lang/String;->substring(II)Ljava/lang/String;

    move-result-object v1

    .line 120
    :cond_3
    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->exactFileNameMatch:Ljava/lang/Boolean;

    invoke-virtual {v5}, Ljava/lang/Boolean;->booleanValue()Z

    move-result v5

    if-eqz v5, :cond_7

    .line 122
    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->caseSensitive:Ljava/lang/Boolean;

    invoke-virtual {v5}, Ljava/lang/Boolean;->booleanValue()Z

    move-result v5

    if-eqz v5, :cond_6

    .line 124
    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->filterFileName:Ljava/lang/String;

    invoke-virtual {v5, v1}, Ljava/lang/String;->equals(Ljava/lang/Object;)Z

    move-result v5

    if-eqz v5, :cond_0

    .line 161
    .end local v1    # "fileName":Ljava/lang/String;
    :cond_4
    const/4 v4, 0x1

    goto :goto_0

    .line 98
    .restart local v0    # "extension":Ljava/lang/String;
    .restart local v3    # "index":I
    :cond_5
    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->filterExtension:Ljava/lang/String;

    invoke-virtual {v5, v0}, Ljava/lang/String;->equalsIgnoreCase(Ljava/lang/String;)Z

    move-result v5

    if-nez v5, :cond_2

    goto :goto_0

    .line 131
    .end local v0    # "extension":Ljava/lang/String;
    .end local v3    # "index":I
    .restart local v1    # "fileName":Ljava/lang/String;
    :cond_6
    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->filterFileName:Ljava/lang/String;

    invoke-virtual {v5, v1}, Ljava/lang/String;->equalsIgnoreCase(Ljava/lang/String;)Z

    move-result v5

    if-nez v5, :cond_4

    goto :goto_0

    .line 139
    :cond_7
    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->caseSensitive:Ljava/lang/Boolean;

    invoke-virtual {v5}, Ljava/lang/Boolean;->booleanValue()Z

    move-result v5

    if-eqz v5, :cond_8

    .line 141
    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->filterFileName:Ljava/lang/String;

    invoke-virtual {v1, v5}, Ljava/lang/String;->contains(Ljava/lang/CharSequence;)Z

    move-result v5

    if-nez v5, :cond_4

    goto/16 :goto_0

    .line 148
    :cond_8
    iget-object v5, p0, Lnet/codestage/actk/androidnative/FileFilter;->filterFileName:Ljava/lang/String;

    invoke-static {v1, v5}, Lnet/codestage/actk/androidnative/NativeUtils;->ContainsIgnoreCase(Ljava/lang/String;Ljava/lang/String;)Z

    move-result v5

    if-nez v5, :cond_4

    goto/16 :goto_0
.end method
