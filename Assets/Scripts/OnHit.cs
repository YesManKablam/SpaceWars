using UnityEngine;
using System.Collections;

public class OnHit : MonoBehaviour {

	void OnCollisionEnter2D(){
		Destroy (gameObject);
	}
}
