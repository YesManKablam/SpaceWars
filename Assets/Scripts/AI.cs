using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	public float maxSpeed = 5f;
	//public Transform target = (5);
	public Vector3 aPosition1 = new Vector3(2,2,0);
	public Vector3 bPosition1 = new Vector3(-2,-2,0);

	bool posRight = false;
	bool posLeft = true;

	// Use this for initialization
	void Start () {
	
	}

	void Example(){

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards (new Vector3 (transform.position.x, transform.position.y), aPosition1, 3 * Time.deltaTime);
		transform.position = Vector3.MoveTowards (new Vector3 (transform.position.x, transform.position.y), bPosition1, 3 * Time.deltaTime);

	}
}
