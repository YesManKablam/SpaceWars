using UnityEngine;
using System.Collections;

public class CurrentScore : EnemySpawnDynamic {

	// Use this for initialization
	void Start () {
		Debug.Log (PlayerPrefs.GetInt("currentScore"));
		if(!PlayerPrefs.HasKey("highScore")){
			PlayerPrefs.SetInt ("highScore", 0);
		}
		int tmpScore = PlayerPrefs.GetInt("currentScore");
		if(tmpScore > PlayerPrefs.GetInt ("highScore"))
		{
			PlayerPrefs.SetInt("highScore", tmpScore);
		}
		Debug.Log("Current Score: " + PlayerPrefs.GetInt("currentScore"));
		Debug.Log ("High Score: " + PlayerPrefs.GetInt ("highScore"));

	
	}
	
	// Update is called once per frame
	void Update () {
	}
}
