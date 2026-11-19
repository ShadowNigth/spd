.class Lnet/codestage/actk/androidnative/CodeHashGenerator$CodeHashCalculator;
.super Landroid/os/AsyncTask;
.source "CodeHashGenerator.java"


# annotations
.annotation system Ldalvik/annotation/EnclosingClass;
    value = Lnet/codestage/actk/androidnative/CodeHashGenerator;
.end annotation

.annotation system Ldalvik/annotation/InnerClass;
    accessFlags = 0xa
    name = "CodeHashCalculator"
.end annotation

.annotation system Ldalvik/annotation/Signature;
    value = {
        "Landroid/os/AsyncTask",
        "<[",
        "Ljava/lang/String;",
        "Ljava/lang/Void;",
        "Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;",
        ">;"
    }
.end annotation


# direct methods
.method private constructor <init>()V
    .locals 0

    .prologue
    .line 33
    invoke-direct {p0}, Landroid/os/AsyncTask;-><init>()V

    return-void
.end method

.method synthetic constructor <init>(Lnet/codestage/actk/androidnative/CodeHashGenerator$1;)V
    .locals 0
    .param p1, "x0"    # Lnet/codestage/actk/androidnative/CodeHashGenerator$1;

    .prologue
    .line 33
    invoke-direct {p0}, Lnet/codestage/actk/androidnative/CodeHashGenerator$CodeHashCalculator;-><init>()V

    return-void
.end method


# virtual methods
.method protected bridge synthetic doInBackground([Ljava/lang/Object;)Ljava/lang/Object;
    .locals 1

    .prologue
    .line 33
    check-cast p1, [[Ljava/lang/String;

    invoke-virtual {p0, p1}, Lnet/codestage/actk/androidnative/CodeHashGenerator$CodeHashCalculator;->doInBackground([[Ljava/lang/String;)Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;

    move-result-object v0

    return-object v0
.end method

.method protected varargs doInBackground([[Ljava/lang/String;)Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;
    .locals 5
    .param p1, "params"    # [[Ljava/lang/String;

    .prologue
    .line 42
    const/4 v3, 0x0

    :try_start_0
    aget-object v3, p1, v3

    invoke-static {v3}, Lnet/codestage/actk/androidnative/CodeHashGenerator;->access$000([Ljava/lang/String;)[Lnet/codestage/actk/androidnative/FileFilter;

    move-result-object v0

    .line 43
    .local v0, "filters":[Lnet/codestage/actk/androidnative/FileFilter;
    invoke-static {v0}, Lnet/codestage/actk/androidnative/CodeHashGenerator;->access$100([Lnet/codestage/actk/androidnative/FileFilter;)Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;
    :try_end_0
    .catch Ljava/lang/Throwable; {:try_start_0 .. :try_end_0} :catch_0

    move-result-object v1

    .line 52
    .end local v0    # "filters":[Lnet/codestage/actk/androidnative/FileFilter;
    .local v1, "result":Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;
    :goto_0
    return-object v1

    .line 45
    .end local v1    # "result":Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;
    :catch_0
    move-exception v2

    .line 47
    .local v2, "x":Ljava/lang/Throwable;
    new-instance v1, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;

    const/4 v3, 0x0

    invoke-direct {v1, v3}, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;-><init>(Lnet/codestage/actk/androidnative/CodeHashGenerator$1;)V

    .line 48
    .restart local v1    # "result":Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;
    new-instance v3, Ljava/lang/StringBuilder;

    invoke-direct {v3}, Ljava/lang/StringBuilder;-><init>()V

    const-string v4, "Something went wrong while trying to hash current APK: "

    invoke-virtual {v3, v4}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v3

    invoke-virtual {v2}, Ljava/lang/Throwable;->toString()Ljava/lang/String;

    move-result-object v4

    invoke-virtual {v3, v4}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v3

    invoke-virtual {v3}, Ljava/lang/StringBuilder;->toString()Ljava/lang/String;

    move-result-object v3

    invoke-static {v3}, Lnet/codestage/actk/androidnative/ACTkErrors;->GetText(Ljava/lang/String;)Ljava/lang/String;

    move-result-object v3

    iput-object v3, v1, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    .line 49
    sget-object v3, Lnet/codestage/actk/androidnative/NativeUtils;->LogTag:Ljava/lang/String;

    iget-object v4, v1, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    invoke-static {v3, v4, v2}, Landroid/util/Log;->e(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I

    goto :goto_0
.end method

.method protected bridge synthetic onPostExecute(Ljava/lang/Object;)V
    .locals 0

    .prologue
    .line 33
    check-cast p1, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;

    invoke-virtual {p0, p1}, Lnet/codestage/actk/androidnative/CodeHashGenerator$CodeHashCalculator;->onPostExecute(Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;)V

    return-void
.end method

.method protected onPostExecute(Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;)V
    .locals 5
    .param p1, "result"    # Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;

    .prologue
    .line 58
    iget-object v0, p1, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    if-eqz v0, :cond_0

    .line 60
    invoke-static {}, Lnet/codestage/actk/androidnative/CodeHashGenerator;->access$300()Lnet/codestage/actk/androidnative/CodeHashCallback;

    move-result-object v0

    iget-object v1, p1, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->errorText:Ljava/lang/String;

    invoke-interface {v0, v1}, Lnet/codestage/actk/androidnative/CodeHashCallback;->OnError(Ljava/lang/String;)V

    .line 66
    :goto_0
    return-void

    .line 64
    :cond_0
    invoke-static {}, Lnet/codestage/actk/androidnative/CodeHashGenerator;->access$300()Lnet/codestage/actk/androidnative/CodeHashCallback;

    move-result-object v0

    iget-object v1, p1, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->buildPath:Ljava/lang/String;

    iget-object v2, p1, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->paths:[Ljava/lang/String;

    iget-object v3, p1, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->hashes:[Ljava/lang/String;

    iget-object v4, p1, Lnet/codestage/actk/androidnative/CodeHashGenerator$HashCalculationResult;->summaryHash:Ljava/lang/String;

    invoke-interface {v0, v1, v2, v3, v4}, Lnet/codestage/actk/androidnative/CodeHashCallback;->OnSuccess(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)V

    goto :goto_0
.end method
