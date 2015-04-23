using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {
	
	public int damage = 0;
	public float invul = 0;
	SpriteRenderer sr;
	public GameObject spawner;
	public GameObject player;

	void Start (){
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
		int currScore;
		if (damage >= 3) {
			//currScore = spawner.GetComponent<EnemySpawnDynamic> ().score;
//			if (currScore == 0) //{
				//currScore = spawner.GetComponent<EnemySpawnerHard> ().score;
			//} else if (currScore == 0) {
			//	currScore = spawner.GetComponent<EnemySpanwerMedium> ().score;
		//	}

		//	PlayerPrefs.SetInt ("currentScore", currScore);
			//Debug.Log ("Player Prefs score: " + PlayerPrefs.GetInt ("currentScore"));
			Destroy (player);
			Debug.Log("Dead");
		//}
	}
}

}