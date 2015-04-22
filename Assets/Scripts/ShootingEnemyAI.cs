using UnityEngine;
using System.Collections;

public class ShootingEnemyAI : MonoBehaviour {

	//Spaceship Component
	ShootingEnemy ship;
	
	IEnumerator Start ()
	{
		// Get the Spaceship component
		ship = GetComponent<ShootingEnemy> ();
		
		while (true) {
			
			// Make the bullet, using the player’s position/rotation
			ship.shoot (transform);
			
			// Wait for shotDelay seconds.
			yield return new WaitForSeconds (ship.bulletCooldown);
		}
	}
	
	void Update ()
	{
		// Right, Left
		float x = Input.GetAxisRaw ("Horizontal");
		
		// Up, Down
		float y = Input.GetAxisRaw ("Vertical");
		
		// Get the facing direction
		Vector2 direction = new Vector2 (x, y).normalized;
		
		// Move
		ship.movement (direction);
	}
}
