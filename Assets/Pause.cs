using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKey ("escape")) {
			Time.timeScale = 0f;
		}*/

		if (Input.GetKey ("e")) {
			Time.timeScale = .5f;
			audio.pitch = Time.timeScale = 0.3f;
		} else {
			Time.timeScale = 1f;
			audio.pitch = Time.timeScale = 1f;
		}
	}
}
