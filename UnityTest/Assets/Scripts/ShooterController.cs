using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShooterController : MonoBehaviour {
	public GameObject bulletPrefab; //prefab for bullet
	public Transform bulletSpawn;   // postion for bullet
	int bulletValue;                // bullet thrown value
	public Text scoreText;          // displaying score 
	public static int score;        // keep score values 
	void Start(){
		
		bulletValue = 0;
		score = 0;
	}

	void Update()
	{
		
		scoreText.text = "Score : " + score.ToString();


		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 120.0f;

		transform.Rotate(-z, x, 0 );


		if (Input.GetKeyDown(KeyCode.Space))
		{
			bulletValue++;
			if(bulletValue<=5)//It can thow five bullets value from table
			{
				Fire();	
			}
		}
		if(Input.GetKeyDown(KeyCode.LeftControl)||Input.GetKeyDown(KeyCode.RightControl)){
			ResetBullet();//load another five bullets
		}
		if(score == 50)
		{
			SceneManager.LoadScene(1);
		}
	}
	void ResetBullet(){
		bulletValue = 0;
	}

	void Fire()
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 2.0f);   
	}
}
