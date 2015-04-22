using UnityEngine;
using System.Collections;

public class EnemyDeath : MonoBehaviour {

	public int damage = 0;
	public int scores = 0;
	public Score score;
	/*void OnGUI()
	{
		GUI.Label (new Rect (0, 0, 100, 50), "Score:" + score);
	}*/


	void OnCollisionEnter2D(){
		damage += 1;
		//score = gameObject.GetComponent<Score>();
		//scores = Score.currScore;

		scores++;
		//points += 1;
		if (damage >= 3) {
			Destroy (gameObject);
		}
	}
}
