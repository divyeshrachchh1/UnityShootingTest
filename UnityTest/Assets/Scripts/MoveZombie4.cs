using UnityEngine;
using System.Collections;

public class MoveZombie4 : MonoBehaviour {

    private HandleSignal signalstatus;
	private Transform[] wayPointList = new Transform[4];//position for path
    public int currentWayPoint = 0;
    Transform targetWayPoint;

    float speed = 4f;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < wayPointList.Length; i++)
        {
            string name = "zombie4path" + i.ToString();
            wayPointList[i] = GameObject.Find(name).transform;
        }
        signalstatus = GameObject.Find("HandleSignal").GetComponent<HandleSignal>();
    }

    // Update is called once per frame
    void Update()
    {
        // check if we have somewere to walk
        if (currentWayPoint < this.wayPointList.Length)
        {
            if (targetWayPoint == null)
                targetWayPoint = wayPointList[currentWayPoint];
            walk();

			//check for signal from table

            if (transform.position == (wayPointList[1].position))
            {
                if (signalstatus.signal3red == true)
                {
                    speed = 4;
                }
                else
                {
                    speed = 0;
                }

            }

			// increase speed of zombie values increase refered from table

            if (transform.position == (wayPointList[2].position))
            {
                speed = Random.Range(6, 8);
            }



        }

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

	// moving object

    void walk()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position, speed * Time.deltaTime);

        if (transform.position == targetWayPoint.position)
        {
            if (currentWayPoint < this.wayPointList.Length - 1)
            {
                currentWayPoint++;
            }
            targetWayPoint = wayPointList[currentWayPoint];
        }
    }
}
