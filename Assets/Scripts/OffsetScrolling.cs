using UnityEngine;
using System.Collections;

public class OffsetScrolling : MonoBehaviour {

	public float scrollingSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float y = Mathf.Repeat (Time.time * scrollingSpeed, 1);
		Vector2 offset = new Vector2 (0, y);
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", offset);
	}
}
