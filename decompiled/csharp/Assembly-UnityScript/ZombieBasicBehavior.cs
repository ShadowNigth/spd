using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class ZombieBasicBehavior : MonoBehaviour
{
	public int zombieState;

	public int newZombieState;

	public float stateChangerCD;

	public float rndNr;

	public BoxCollider myBoxCollider;

	public GameObject blood;

	public int HP;

	public int HPCD;

	public GameObject Zombie;

	public GameObject[] createThis;

	public ZombieBasicBehavior()
	{
		HP = 3;
	}

	public virtual void Start()
	{
		stateChangerCD = 3f;
		zombieState = 2;
		rndNr = Mathf.Ceil(UnityEngine.Random.value * (float)Extensions.get_length((System.Array)createThis));
		rndNr -= 1f;
		Zombie = UnityEngine.Object.Instantiate(createThis[(int)rndNr], transform.position, transform.rotation);
		Zombie.transform.parent = transform;
	}

	public virtual void Update()
	{
		if (HPCD > 0)
		{
			HPCD = (int)((float)HPCD - Time.deltaTime);
		}
		stateChangerCD -= Time.deltaTime;
		if (!(stateChangerCD >= 0f))
		{
			stateChangerCD = 1.5f + UnityEngine.Random.value;
			if (zombieState == 0)
			{
				rndNr = UnityEngine.Random.value * 100f;
				if (!(rndNr >= 20f))
				{
					newZombieState = 0;
				}
				if (!(rndNr < 20f) && !(rndNr > 30f))
				{
					newZombieState = 1;
				}
				if (!(rndNr <= 30f) && !(rndNr > 100f))
				{
					newZombieState = 2;
				}
			}
			if (zombieState == 1)
			{
				rndNr = UnityEngine.Random.value * 100f;
				if (!(rndNr >= 20f))
				{
					newZombieState = 0;
				}
				if (!(rndNr < 20f) && !(rndNr > 80f))
				{
					newZombieState = 1;
				}
				if (!(rndNr <= 80f) && !(rndNr > 90f))
				{
					newZombieState = 2;
				}
				if (!(rndNr <= 90f) && !(rndNr > 100f))
				{
					newZombieState = 3;
				}
			}
			if (zombieState == 2)
			{
				rndNr = UnityEngine.Random.value * 100f;
				if (!(rndNr >= 20f))
				{
					newZombieState = 0;
				}
				if (!(rndNr < 20f) && !(rndNr > 60f))
				{
					newZombieState = 1;
				}
				if (!(rndNr <= 60f) && !(rndNr > 90f))
				{
					newZombieState = 2;
				}
				if (!(rndNr <= 90f) && !(rndNr > 100f))
				{
					newZombieState = 3;
					stateChangerCD = 0.5f;
				}
			}
			if (zombieState == 3)
			{
				newZombieState = 4;
				stateChangerCD = 0.5f;
			}
			if (zombieState == 4)
			{
				rndNr = UnityEngine.Random.value * 100f;
				if (!(rndNr < 0f) && !(rndNr > 50f))
				{
					newZombieState = 5;
				}
				if (!(rndNr <= 50f) && !(rndNr > 100f))
				{
					newZombieState = 6;
					stateChangerCD = 1f;
				}
			}
			if (zombieState == 5)
			{
				rndNr = UnityEngine.Random.value * 100f;
				if (!(rndNr < 0f) && !(rndNr > 90f))
				{
					newZombieState = 5;
				}
				if (!(rndNr <= 90f) && !(rndNr > 100f))
				{
					newZombieState = 6;
					stateChangerCD = 1f;
				}
			}
			if (zombieState == 6)
			{
				newZombieState = 0;
			}
			if (zombieState == 7)
			{
				newZombieState = 7;
				myBoxCollider.size = new Vector3(0f, 0f, 0f);
				UnityEngine.Object.Destroy(gameObject, 1.3f);
				stateChangerCD = 10f;
			}
			if (zombieState == 8)
			{
				newZombieState = 0;
			}
			if (zombieState == 9)
			{
				newZombieState = 0;
			}
			if (zombieState == 10 || zombieState == 11)
			{
				newZombieState = (int)(Mathf.Ceil(UnityEngine.Random.value * 2f) + 9f);
				stateChangerCD = 0.5f;
			}
			zombieState = newZombieState;
		}
		if (zombieState == 0 && !Zombie.GetComponent<Animation>().IsPlaying("idle"))
		{
			Zombie.GetComponent<Animation>().CrossFade("idle", 0.3f);
		}
		if (zombieState == 1)
		{
			transform.Translate(0f, 0f, 1f * Time.deltaTime);
			if (!Zombie.GetComponent<Animation>().IsPlaying("shamble"))
			{
				Zombie.GetComponent<Animation>().CrossFade("shamble", 0.3f);
			}
		}
		if (zombieState == 2)
		{
			transform.Translate(0f, 0f, 1f * Time.deltaTime);
			if (!Zombie.GetComponent<Animation>().IsPlaying("walk"))
			{
				Zombie.GetComponent<Animation>().CrossFade("walk", 0.3f);
			}
		}
		if (zombieState == 3 && !Zombie.GetComponent<Animation>().IsPlaying("fallToFace"))
		{
			Zombie.GetComponent<Animation>().CrossFade("fallToFace", 0.1f);
		}
		if (zombieState == 4 && !Zombie.GetComponent<Animation>().IsPlaying("beginToCrawl"))
		{
			Zombie.GetComponent<Animation>().CrossFade("beginToCrawl", 0.1f);
		}
		if (zombieState == 5)
		{
			transform.Translate(0f, 0f, 1f * Time.deltaTime);
			if (!Zombie.GetComponent<Animation>().IsPlaying("crawl"))
			{
				Zombie.GetComponent<Animation>().CrossFade("crawl", 0.1f);
			}
		}
		if (zombieState == 6 && !Zombie.GetComponent<Animation>().IsPlaying("standUp"))
		{
			Zombie.GetComponent<Animation>().CrossFade("standUp", 0.1f);
		}
		if (zombieState == 7 && !Zombie.GetComponent<Animation>().IsPlaying("fallBack"))
		{
			Zombie.GetComponent<Animation>().CrossFade("fallBack", 0.1f);
		}
		if (zombieState == 8 && !Zombie.GetComponent<Animation>().IsPlaying("hit1"))
		{
			Zombie.GetComponent<Animation>().CrossFade("hit1", 0.1f);
		}
		if (zombieState == 9 && !Zombie.GetComponent<Animation>().IsPlaying("hit2"))
		{
			Zombie.GetComponent<Animation>().CrossFade("hit2", 0.1f);
		}
		if (zombieState == 10 && !Zombie.GetComponent<Animation>().IsPlaying("attack1"))
		{
			Zombie.GetComponent<Animation>().CrossFade("attack1", 0.1f);
		}
		if (zombieState == 11 && !Zombie.GetComponent<Animation>().IsPlaying("attack2"))
		{
			Zombie.GetComponent<Animation>().CrossFade("attack2", 0.1f);
		}
	}

	public virtual void OnTriggerEnter(Collider OBKENFAPMCF)
	{
		if (OBKENFAPMCF.tag == "barrier" && zombieState != 10)
		{
			Debug.Log("barrierFound");
			zombieState = 10;
			stateChangerCD = 0.01f;
		}
		if (OBKENFAPMCF.tag == "explo")
		{
			UnityEngine.Object.Instantiate(blood, transform.position, transform.rotation);
			if (HP == 1)
			{
				zombieState = 7;
				stateChangerCD = 0.01f;
			}
			if (HP > 1 && HPCD <= 0)
			{
				stateChangerCD = 0.7f;
				zombieState = (int)(7f + Mathf.Ceil(UnityEngine.Random.value * 2f));
				HPCD = 0;
				HP--;
			}
		}
	}

	public virtual void Main()
	{
	}
}
