using UnityEngine;
using System.Collections;

public class EnemySpawnDynamic : MonoBehaviour {
	
	public GameObject enemy0;
	public GameObject enemy1;
	GameObject enemyInstance0;
	GameObject enemyInstance1;
	public int spawnLocation;
	public float timer; 
	public float difficulty = 60f;
	public GUIText Score;
	public int score;
	

	void Start(){
		PlayerPrefs.SetInt("currentScore", 0);
		score = 0;
	}

	void spawn()
	{
		if (difficulty >= 50)
		{
			spawnLocation = Random.Range (5, 8);
			timer = 1;
		}

		else if (difficulty >= 40)
		{
			spawnLocation = Random.Range (5, 8);
			timer = 2;
		}

		else if (difficulty >= 30)
		{
			spawnLocation = Random.Range (3, 7);
			timer = 1;
		}

		else if (difficulty >= 20)
		{
			spawnLocation = Random.Range (3, 5);
			timer = 2;
		}

		else if (difficulty >= 10)
		{
			spawnLocation = Random.Range (1, 3);
			timer = 1;
		}

		else {
			spawnLocation = Random.Range (1, 2); // Random.Range is inclusive for min, and exclusive for max.
			timer = 2;
		}
		
		switch (spawnLocation) 
		{
		case 1:
			spawnPos0();
			//spawnPos4 ();
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
		case 5:
			spawnPos4();
			break;
		case 6:
			spawnPos5();
			break;
		}
	}

	void spawnPos0 ()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (4, 10, -2), Quaternion.identity);
		Debug.Log ("0");
		score += 1;
	}

	void spawnPos1 ()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-4, 10, -2), Quaternion.identity);
		Debug.Log ("1");
		score += 1;
	}
	
	void spawnPos2 ()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (4, -10, -2), Quaternion.identity);
		Debug.Log ("2");
		score += 1;
	}
	
	void spawnPos3 ()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-4, -10, -2), Quaternion.identity);
		Debug.Log ("3");
		score += 1;
	}

	void spawnPos4 ()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (2, 2, -2), Quaternion.identity);
		Debug.Log ("4");
		score += 1;
	}

	void spawnPos5 ()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-2, -2, -2), Quaternion.identity);
		Debug.Log ("5");
		score += 1;
	}
	


	//void spawnPos
	
	/*void spawnPos0()
	{
		int enemy;
		enemy = Random.Range (1, 3);
		if (enemy == 1) {
			enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (4, 10, -2), Quaternion.identity);
			enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-4, 10, -2), Quaternion.identity);
		} else if (enemy == 2) {
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (-4, 10, -2), Quaternion.identity); //
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (-2, 10, -2), Quaternion.identity); //
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (2, 10, -2), Quaternion.identity); //
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (4, 10, -2), Quaternion.identity); //
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (1, 8, -2), Quaternion.identity); //
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (3, 8, -2), Quaternion.identity); //
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (-3, 8, -2), Quaternion.identity); //
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (-1, 8, -2), Quaternion.identity); //
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (0, 6, -2), Quaternion.identity); //
		}
	}
	
	void spawnPos1()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (4, -10, -2), Quaternion.identity);
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-4, -10, -2), Quaternion.identity);
	}
	
	void spawnPos2()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (10, 4, -2), Quaternion.identity);
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (10, -4, -2), Quaternion.identity);
	}
	
	void spawnPos3()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-10, 4, -2), Quaternion.identity);
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-10, -4, -2), Quaternion.identity);
	}

	void spawnVoid4()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (4, 10, -2), Quaternion.identity);
	}*/
	
	void Update()
	{
		timer -= Time.deltaTime;
		difficulty -= Time.deltaTime;
		if (timer <= 0)
		{
			spawn ();
		}

		//Score.text = "Eniemes: " + score;


		//if (difficulty == 30)
		//{
		//	Application.LoadLevel(4);
		//}
	}

	/*public void LoadScene(int level)
	{
		Application.LoadLevel(level);
	}*/
}