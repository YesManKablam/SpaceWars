using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))] // Makes sure that this object won't get delleted.
public class ShootingEnemy : MonoBehaviour {

	public float movementSpeed;
	public float bulletCooldown;
	public GameObject bullet;

	public void shoot(Transform origin)
	{
		Instantiate (bullet, origin.position, origin.rotation); // Generates the bullet on the screen
	}
		
	public void movement(Vector2 direction)
	{
		rigidbody2D.velocity = direction * movementSpeed; // Moves the enemy ship
	}
}
