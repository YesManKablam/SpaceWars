using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {
	
	public int damage = 0;
	public float invul = 0;
	int startLayer;
	SpriteRenderer sr;
	public GameObject spawner;

	void Start (){
		startLayer = gameObject.layer;
		spawner = GameObject.Find ("EnemySpawn");
		sr = GetComponent<SpriteRenderer> ();

		if (sr == null) {
			Debug.LogError("The ' "+gameObject.name+"' has no sprite renderer");
		}
	}

	void OnCollisionEnter2D(){
		damage += 1;
		invul += 10;
		gameObject.layer = 10;
		if (damage >= 3) {
			int currScore;
			currScore = spawner.GetComponent<EnemySpawnDynamic>().score;
			PlayerPrefs.SetInt("currentScore", currScore);
			Debug.Log ("Player Prefs score: " + PlayerPrefs.GetInt("currentScore"));
			Destroy (gameObject);
		}
	}

	void Update()
	{
		if (invul > 0) 
		{
			invul -= Time.deltaTime;
			if (invul <= 0) 
			{
				gameObject.layer = startLayer;
				if(sr != null)
				{
					sr.enabled = true;
				}
			}
			else
			{
				if(sr != null)
				{
					sr.enabled = !sr.enabled;
				}
			}
		}
	}
}

