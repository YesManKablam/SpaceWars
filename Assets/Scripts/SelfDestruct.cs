using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

	public float timer = 1f;
	public int score = 0;

	void Update () {

		timer -= Time.deltaTime;

		if(timer <= 0) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(){
		score ++;
	}

	/*void OnGUI()
	{
		GUI.Label (new Rect (0, 0, 100, 50), "Score: " + score);
	}*/
}
