using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedZombie : MonoBehaviour {

	 Transform target;
	float speed = 5;
	// Use this for initialization
	void Start () {
		target = GameObject.Find("Redzombiepos").transform;
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}
	//score system values refered from table

	void OnCollisionEnter (Collision col)
	{
		Debug.Log(col.gameObject.name);
		Destroy(this.gameObject);
		if(col.gameObject.activeInHierarchy)
		{
			Destroy(col.gameObject);
		}
		ShooterController.score+=5;

	}
}
