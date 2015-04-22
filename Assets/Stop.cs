using UnityEngine;
using System.Collections;

public class Stop : MonoBehaviour {

	bool pause;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("escape") && pause == false) {
			//Time.timeScale = 0f;
			Debug.Log ("Paused");
			pause = true;
		}

		if (pause)
			Time.timeScale = 0f;
		/*else if (Input.GetKey ("escape") && pause == true){
			Time.timeScale = 1f;
			Debug.Log ("Playing");
			pause = false;
		}*/
	}
}
