using UnityEngine;
using System.Collections;

public class PlayerFire : MonoBehaviour {

	public GameObject bullet;
	public Vector3 bulletOffset = new Vector3(0,1f,0); // Location of the bullet will be slightly ahead of the sprite
	public float bulletCooldown = .5f; // Time between shots. Can be changed from unity's menus.
	public float internalCooldown; // Will be asigned the same time as the bulletCooldown, avoids having to hardcode the intervals 

	/*IEnumerator Start ()
	{
		while (true) {
			// Make a bullet with the same position and rotation as the player
			Instantiate (bullet, transform.position, transform.rotation);
			// Wait 0.05 seconds
			yield return new WaitForSeconds (0.05f);
		}
	}*/

	void Update ()
	{
		internalCooldown = bulletCooldown; // Internal is now the changeable delay
		internalCooldown -= Time.deltaTime; // Counts down in realtime

		if (internalCooldown == 0)
		{
			internalCooldown = bulletCooldown; // Sets the internal delay back to what the changeable one is
			Vector3 offset = transform.rotation * bulletOffset; // Makes sure the bullet moves, but starts with the offset set above

			GameObject readyBullet = (GameObject)Instantiate(bullet, transform.position + offset, transform.rotation); // Moves the bullets, but uses the above transformations 
		}
	}
}
