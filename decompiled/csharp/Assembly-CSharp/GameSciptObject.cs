using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class GameSciptObject : ScriptableObject
{
	[Header("Field")]
	public ObscuredBool AutoShoot;

	public ObscuredBool AimDownSights;

	public ObscuredBool EnableRun;

	public ObscuredBool enableShootingZombies;

	public ObscuredBool EnableBarricades;

	public ObscuredBool nextRoundRemoveZombies;

	public ObscuredBool canBuyWeaponsAnyTime;

	public ObscuredBool ObservingOwnTeam;

	public ObscuredBool DisableCursor;

	public ObscuredBool FriendlyFire;

	public ObscuredBool delayedBullets;

	public ObscuredBool EnableStartTime = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE: true);

	public ObscuredFloat AutoShootStartsIn = ObscuredFloat.FNIPJFGEFFD(0.3f);

	public ObscuredFloat fireBallSpeed = ObscuredFloat.FNIPJFGEFFD(10f);

	public ObscuredFloat spawnInterval = ObscuredFloat.FNIPJFGEFFD(8f);

	public ObscuredFloat bulletSpeed = ObscuredFloat.FNIPJFGEFFD(100f);

	public ObscuredFloat zombieDamage = ObscuredFloat.FNIPJFGEFFD(100f);

	public ObscuredInt zombieShootingINterval = ObscuredInt.FNIPJFGEFFD(3);

	public ObscuredInt BaricadeLife = ObscuredInt.FNIPJFGEFFD(100);

	public ObscuredBool killAwardsEnabled = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE: true);

	public ObscuredBool bigHitBox;

	public ObscuredBool enableGunAmout;

	public ObscuredBool disableHeadshot;

	public ObscuredBool jumpShoot = ObscuredBool.FNIPJFGEFFD(EHAPKEKPMOE: true);

	public ObscuredBool spawnKill;

	[Header("NotField")]
	public bool showYouCanAddBotsMessage = true;

	public bool ShootThroughWalls;

	public bool EnableThirdPersonView;

	public bool secondControll;

	public bool EnableSlowDown = true;

	public bool EnableHealing;

	public bool Special;

	public bool enableVoiceChat;

	public bool dontPackLevel;

	public bool predict;

	public bool onDisabling;

	public bool hasNavMesh;

	public bool EnableMatrix;

	public bool defused;

	public bool exploded;

	public bool LimitHealth = true;

	public bool antiSwitchShoot;

	public bool Wait;

	public bool gameStarted;

	public bool mbClick;

	public bool doubleTouchJump;

	public bool doubleTouchCrouch;

	public bool PadDoubleTouch;

	public bool StartJoined;

	public bool customAmbient;

	public bool customFogEnabled;

	public bool ShowEnemyOnRadar;

	public bool PacketsReceived;

	public float TimeScale = 1f;

	public float MapScale = 100f;

	public float spaceModLaserSpeed = 10f;

	public float MatrixGameSpeed = 0.6f;

	public float zombieHealthFactor = 1f;

	public float zombieHealthFactorDeff = 0.7f;

	public float zombieSpeedFactor = 1f;

	public float zombieSpeedFactorDeff = 0.5f;

	public float lastDieTime;

	public float botSpawn = 5f;

	public float botSpawnDef = 5f;

	public float botAccuracy = 1f;

	public float botAccuracyDef = 0.1f;

	public float botHealth = 100f;

	public float botHealthDef = 100f;

	public float mapScale2 = 1f;

	public float LastVoteKick;

	public float lastNonAutoSHoot;

	public float roundInterval = 60f;

	public float roundIntervalDef = 60f;

	public float stageTime;

	public float resetGameTime;

	public float survTerroristss = 0.5f;

	public float survMonsterss;

	public float survFattyss;

	public float survKamikaze = 0.5f;

	public float lastMoveTouchJump;

	public float lastMoveTouchCrouch;

	public float Pad2Factor = 50f;

	public float push = 0.2f;

	public float buyTimeMax = 20f;

	public int BotCount;

	public int visUpdateFromLineFactor = 100;

	public int visUpdateDistance = 500;
}
