using UnityEngine;
using System.Collections;

public class FourWayMovement : MonoBehaviour {

	float shipBoundaryRadius = 0.5f;
	public float maxSpeed = 5f;
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
		pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
		transform.position = pos;
	
		// First to vertical, because it's simpler
		if(pos.y+shipBoundaryRadius > Camera.main.orthographicSize) {
			pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
		}
		if(pos.y-shipBoundaryRadius < -Camera.main.orthographicSize) {
			pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
		}
		
		// Now calculate the orthographic width based on the screen ratio
		float screenRatio = (float)Screen.width / (float)Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;
		
		// Now do horizontal bounds
		if(pos.x+shipBoundaryRadius > widthOrtho) {
			pos.x = widthOrtho - shipBoundaryRadius;
		}
		if(pos.x-shipBoundaryRadius < -widthOrtho) {
			pos.x = -widthOrtho + shipBoundaryRadius;
		}
		
		// Finally, update our position!!
		transform.position = pos;
}
}