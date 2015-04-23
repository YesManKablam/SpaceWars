using UnityEngine;
using System.Collections;

public class EnemySpanwerMedium : MonoBehaviour {
	
	public GameObject enemy0;
	public GameObject enemy1;
	GameObject enemyInstance0;
	GameObject enemyInstance1;
	public int spawnLocation;
	public float timer; 
	public int score;

	void Start(){
		PlayerPrefs.SetInt("currentScore", 0);
		score = 0;
	}

	void spawn()
	{
		spawnLocation = Random.Range (1,5); // Random.Range is inclusive for min, and exclusive for max.
		timer = 2;
		
		switch (spawnLocation) 
		{
		case 1:
			spawnPos0();
			break;
		case 2:
			spawnPos1();
			break;
		case 3:
			spawnPos2();
			break;
		case 4:
			spawnPos3();
			break;
		}
	}
	
	void spawnPos0()
	{
		int enemy;
		enemy = Random.Range (1, 3);
		if (enemy == 1) {
			enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (0, 10, -2), Quaternion.identity);
			score+=1;
		} else {
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (-4, 10, -2), Quaternion.identity);
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (-2, 10, -2), Quaternion.identity);
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (2, 10, -2), Quaternion.identity);
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (4, 10, -2), Quaternion.identity);
			score+=4;

		}
	}
	
	void spawnPos1()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (0, -10, -2), Quaternion.identity);
		score+=1;
	}

	void spawnPos2()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (10, 0, -2), Quaternion.identity);
		score+=1;
	}

	void spawnPos3()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-10, 0, -2), Quaternion.identity);
		score+=1;
	}
	
	void Update()
	{
		timer -= Time.deltaTime;
		if (timer <= 0)
		{
			spawn ();
		}
	}
}
