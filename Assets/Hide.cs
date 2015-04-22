using UnityEngine;
using System.Collections;

public class Hide : MonoBehaviour {

	public GameObject menu;

	void Start(){
		//gameObject.GetComponent<CanvasGroup> ().alpha = 0f;
		menu.GetComponent<CanvasGroup> ().alpha = 0f;
	}
}
