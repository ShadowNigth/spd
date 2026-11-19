.class final Lcom/unity3d/player/o;
.super Ljava/lang/Object;


# annotations
.annotation system Ldalvik/annotation/MemberClasses;
    value = {
        Lcom/unity3d/player/o$a;
    }
.end annotation


# instance fields
.field private a:Lcom/unity3d/player/UnityPlayer;

.field private b:Landroid/content/Context;

.field private c:Lcom/unity3d/player/o$a;

.field private final d:Ljava/util/concurrent/Semaphore;

.field private final e:Ljava/util/concurrent/locks/Lock;

.field private f:Lcom/unity3d/player/n;

.field private g:I

.field private h:Z

.field private i:Z


# direct methods
.method constructor <init>(Lcom/unity3d/player/UnityPlayer;)V
    .locals 3

    const/4 v2, 0x0

    const/4 v1, 0x0

    invoke-direct {p0}, Ljava/lang/Object;-><init>()V

    iput-object v2, p0, Lcom/unity3d/player/o;->a:Lcom/unity3d/player/UnityPlayer;

    iput-object v2, p0, Lcom/unity3d/player/o;->b:Landroid/content/Context;

    new-instance v0, Ljava/util/concurrent/Semaphore;

    invoke-direct {v0, v1}, Ljava/util/concurrent/Semaphore;-><init>(I)V

    iput-object v0, p0, Lcom/unity3d/player/o;->d:Ljava/util/concurrent/Semaphore;

    new-instance v0, Ljava/util/concurrent/locks/ReentrantLock;

    invoke-direct {v0}, Ljava/util/concurrent/locks/ReentrantLock;-><init>()V

    iput-object v0, p0, Lcom/unity3d/player/o;->e:Ljava/util/concurrent/locks/Lock;

    iput-object v2, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    const/4 v0, 0x2

    iput v0, p0, Lcom/unity3d/player/o;->g:I

    iput-boolean v1, p0, Lcom/unity3d/player/o;->h:Z

    iput-boolean v1, p0, Lcom/unity3d/player/o;->i:Z

    iput-object p1, p0, Lcom/unity3d/player/o;->a:Lcom/unity3d/player/UnityPlayer;

    return-void
.end method

.method static synthetic a(Lcom/unity3d/player/o;I)I
    .locals 0

    iput p1, p0, Lcom/unity3d/player/o;->g:I

    return p1
.end method

.method static synthetic a(Lcom/unity3d/player/o;)Lcom/unity3d/player/n;
    .locals 1

    iget-object v0, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    return-object v0
.end method

.method static synthetic a(Lcom/unity3d/player/o;Lcom/unity3d/player/n;)Lcom/unity3d/player/n;
    .locals 0

    iput-object p1, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    return-object p1
.end method

.method static synthetic b(Lcom/unity3d/player/o;)Ljava/util/concurrent/Semaphore;
    .locals 1

    iget-object v0, p0, Lcom/unity3d/player/o;->d:Ljava/util/concurrent/Semaphore;

    return-object v0
.end method

.method static synthetic c(Lcom/unity3d/player/o;)Landroid/content/Context;
    .locals 1

    iget-object v0, p0, Lcom/unity3d/player/o;->b:Landroid/content/Context;

    return-object v0
.end method

.method static synthetic d(Lcom/unity3d/player/o;)Ljava/util/concurrent/locks/Lock;
    .locals 1

    iget-object v0, p0, Lcom/unity3d/player/o;->e:Ljava/util/concurrent/locks/Lock;

    return-object v0
.end method

.method private d()V
    .locals 2

    iget-object v0, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    if-eqz v0, :cond_0

    iget-object v0, p0, Lcom/unity3d/player/o;->a:Lcom/unity3d/player/UnityPlayer;

    iget-object v1, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    invoke-virtual {v0, v1}, Lcom/unity3d/player/UnityPlayer;->removeViewFromPlayer(Landroid/view/View;)V

    const/4 v0, 0x0

    iput-boolean v0, p0, Lcom/unity3d/player/o;->i:Z

    iget-object v0, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    invoke-virtual {v0}, Lcom/unity3d/player/n;->destroyPlayer()V

    const/4 v0, 0x0

    iput-object v0, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    iget-object v0, p0, Lcom/unity3d/player/o;->c:Lcom/unity3d/player/o$a;

    if-eqz v0, :cond_0

    iget-object v0, p0, Lcom/unity3d/player/o;->c:Lcom/unity3d/player/o$a;

    invoke-interface {v0}, Lcom/unity3d/player/o$a;->a()V

    :cond_0
    return-void
.end method

.method static synthetic e(Lcom/unity3d/player/o;)Z
    .locals 1

    iget-boolean v0, p0, Lcom/unity3d/player/o;->i:Z

    return v0
.end method

.method static synthetic f(Lcom/unity3d/player/o;)V
    .locals 0

    invoke-direct {p0}, Lcom/unity3d/player/o;->d()V

    return-void
.end method

.method static synthetic g(Lcom/unity3d/player/o;)Lcom/unity3d/player/UnityPlayer;
    .locals 1

    iget-object v0, p0, Lcom/unity3d/player/o;->a:Lcom/unity3d/player/UnityPlayer;

    return-object v0
.end method

.method static synthetic h(Lcom/unity3d/player/o;)Z
    .locals 1

    const/4 v0, 0x1

    iput-boolean v0, p0, Lcom/unity3d/player/o;->i:Z

    return v0
.end method


# virtual methods
.method public final a()V
    .locals 1

    iget-object v0, p0, Lcom/unity3d/player/o;->e:Ljava/util/concurrent/locks/Lock;

    invoke-interface {v0}, Ljava/util/concurrent/locks/Lock;->lock()V

    iget-object v0, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    if-eqz v0, :cond_0

    iget v0, p0, Lcom/unity3d/player/o;->g:I

    if-nez v0, :cond_1

    iget-object v0, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    invoke-virtual {v0}, Lcom/unity3d/player/n;->CancelOnPrepare()V

    :cond_0
    :goto_0
    iget-object v0, p0, Lcom/unity3d/player/o;->e:Ljava/util/concurrent/locks/Lock;

    invoke-interface {v0}, Ljava/util/concurrent/locks/Lock;->unlock()V

    return-void

    :cond_1
    iget-boolean v0, p0, Lcom/unity3d/player/o;->i:Z

    if-eqz v0, :cond_0

    iget-object v0, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    invoke-virtual {v0}, Lcom/unity3d/player/n;->a()Z

    move-result v0

    iput-boolean v0, p0, Lcom/unity3d/player/o;->h:Z

    iget-boolean v0, p0, Lcom/unity3d/player/o;->h:Z

    if-nez v0, :cond_0

    iget-object v0, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    invoke-virtual {v0}, Lcom/unity3d/player/n;->pause()V

    goto :goto_0
.end method

.method public final a(Landroid/content/Context;Ljava/lang/String;IIIZJJLcom/unity3d/player/o$a;)Z
    .locals 15

    iget-object v2, p0, Lcom/unity3d/player/o;->e:Ljava/util/concurrent/locks/Lock;

    invoke-interface {v2}, Ljava/util/concurrent/locks/Lock;->lock()V

    move-object/from16 v0, p11

    iput-object v0, p0, Lcom/unity3d/player/o;->c:Lcom/unity3d/player/o$a;

    move-object/from16 v0, p1

    iput-object v0, p0, Lcom/unity3d/player/o;->b:Landroid/content/Context;

    iget-object v2, p0, Lcom/unity3d/player/o;->d:Ljava/util/concurrent/Semaphore;

    invoke-virtual {v2}, Ljava/util/concurrent/Semaphore;->drainPermits()I

    const/4 v2, 0x2

    iput v2, p0, Lcom/unity3d/player/o;->g:I

    new-instance v3, Lcom/unity3d/player/o$1;

    move-object v4, p0

    move-object/from16 v5, p2

    move/from16 v6, p3

    move/from16 v7, p4

    move/from16 v8, p5

    move/from16 v9, p6

    move-wide/from16 v10, p7

    move-wide/from16 v12, p9

    invoke-direct/range {v3 .. v13}, Lcom/unity3d/player/o$1;-><init>(Lcom/unity3d/player/o;Ljava/lang/String;IIIZJJ)V

    invoke-virtual {p0, v3}, Lcom/unity3d/player/o;->runOnUiThread(Ljava/lang/Runnable;)V

    const/4 v2, 0x0

    :try_start_0
    iget-object v3, p0, Lcom/unity3d/player/o;->e:Ljava/util/concurrent/locks/Lock;

    invoke-interface {v3}, Ljava/util/concurrent/locks/Lock;->unlock()V

    iget-object v3, p0, Lcom/unity3d/player/o;->d:Ljava/util/concurrent/Semaphore;

    invoke-virtual {v3}, Ljava/util/concurrent/Semaphore;->acquire()V

    iget-object v3, p0, Lcom/unity3d/player/o;->e:Ljava/util/concurrent/locks/Lock;

    invoke-interface {v3}, Ljava/util/concurrent/locks/Lock;->lock()V

    iget v2, p0, Lcom/unity3d/player/o;->g:I
    :try_end_0
    .catch Ljava/lang/InterruptedException; {:try_start_0 .. :try_end_0} :catch_0

    const/4 v3, 0x2

    if-eq v2, v3, :cond_0

    const/4 v2, 0x1

    :goto_0
    new-instance v3, Lcom/unity3d/player/o$2;

    invoke-direct {v3, p0}, Lcom/unity3d/player/o$2;-><init>(Lcom/unity3d/player/o;)V

    invoke-virtual {p0, v3}, Lcom/unity3d/player/o;->runOnUiThread(Ljava/lang/Runnable;)V

    if-eqz v2, :cond_1

    iget v3, p0, Lcom/unity3d/player/o;->g:I

    const/4 v4, 0x3

    if-eq v3, v4, :cond_1

    new-instance v3, Lcom/unity3d/player/o$3;

    invoke-direct {v3, p0}, Lcom/unity3d/player/o$3;-><init>(Lcom/unity3d/player/o;)V

    invoke-virtual {p0, v3}, Lcom/unity3d/player/o;->runOnUiThread(Ljava/lang/Runnable;)V

    :goto_1
    iget-object v3, p0, Lcom/unity3d/player/o;->e:Ljava/util/concurrent/locks/Lock;

    invoke-interface {v3}, Ljava/util/concurrent/locks/Lock;->unlock()V

    return v2

    :cond_0
    const/4 v2, 0x0

    goto :goto_0

    :cond_1
    new-instance v3, Lcom/unity3d/player/o$4;

    invoke-direct {v3, p0}, Lcom/unity3d/player/o$4;-><init>(Lcom/unity3d/player/o;)V

    invoke-virtual {p0, v3}, Lcom/unity3d/player/o;->runOnUiThread(Ljava/lang/Runnable;)V

    goto :goto_1

    :catch_0
    move-exception v3

    goto :goto_0
.end method

.method public final b()V
    .locals 1

    iget-object v0, p0, Lcom/unity3d/player/o;->e:Ljava/util/concurrent/locks/Lock;

    invoke-interface {v0}, Ljava/util/concurrent/locks/Lock;->lock()V

    iget-object v0, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    if-eqz v0, :cond_0

    iget-boolean v0, p0, Lcom/unity3d/player/o;->i:Z

    if-eqz v0, :cond_0

    iget-boolean v0, p0, Lcom/unity3d/player/o;->h:Z

    if-nez v0, :cond_0

    iget-object v0, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    invoke-virtual {v0}, Lcom/unity3d/player/n;->start()V

    :cond_0
    iget-object v0, p0, Lcom/unity3d/player/o;->e:Ljava/util/concurrent/locks/Lock;

    invoke-interface {v0}, Ljava/util/concurrent/locks/Lock;->unlock()V

    return-void
.end method

.method public final c()V
    .locals 1

    iget-object v0, p0, Lcom/unity3d/player/o;->e:Ljava/util/concurrent/locks/Lock;

    invoke-interface {v0}, Ljava/util/concurrent/locks/Lock;->lock()V

    iget-object v0, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    if-eqz v0, :cond_0

    iget-object v0, p0, Lcom/unity3d/player/o;->f:Lcom/unity3d/player/n;

    invoke-virtual {v0}, Lcom/unity3d/player/n;->updateVideoLayout()V

    :cond_0
    iget-object v0, p0, Lcom/unity3d/player/o;->e:Ljava/util/concurrent/locks/Lock;

    invoke-interface {v0}, Ljava/util/concurrent/locks/Lock;->unlock()V

    return-void
.end method

.method protected final runOnUiThread(Ljava/lang/Runnable;)V
    .locals 2

    iget-object v0, p0, Lcom/unity3d/player/o;->b:Landroid/content/Context;

    instance-of v0, v0, Landroid/app/Activity;

    if-eqz v0, :cond_0

    iget-object v0, p0, Lcom/unity3d/player/o;->b:Landroid/content/Context;

    check-cast v0, Landroid/app/Activity;

    invoke-virtual {v0, p1}, Landroid/app/Activity;->runOnUiThread(Ljava/lang/Runnable;)V

    :goto_0
    return-void

    :cond_0
    const/4 v0, 0x5

    const-string v1, "Not running from an Activity; Ignoring execution request..."

    invoke-static {v0, v1}, Lcom/unity3d/player/e;->Log(ILjava/lang/String;)V

    goto :goto_0
.end method
