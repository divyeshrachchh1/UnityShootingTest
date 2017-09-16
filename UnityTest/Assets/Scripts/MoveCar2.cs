using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar2 : MonoBehaviour
{

    // put the points from unity interface
    public HandleSignal signalstatus;
	public Transform[] wayPointList;//position for path

    public int currentWayPoint = 0;
    Transform targetWayPoint;

     float speed = 4f;

    // Use this for initialization
    void Start()
    {
	        
    }
  
    // Update is called once per frame
    void Update()
    {
        // check if we have somewere to walk
        if (currentWayPoint < this.wayPointList.Length - 1)
        {
            if (targetWayPoint == null)
                targetWayPoint = wayPointList[currentWayPoint];
            walk();
           
			//check for signal from table

            if (transform.position == (wayPointList[7].position) )
            {
                if (signalstatus.signal3red == true)
                {
                    speed = 0;
                }
                else
                {
                    speed = 4;
                }
                
            }
           
            if (transform.position == (wayPointList[5].position) )
            {
                if(signalstatus.signal4red == true)
                {
                    speed = 0;
                }
                else
                {
                    speed = 4;
                }
            }
           
            if (transform.position == (wayPointList[3].position))
            {
                if (signalstatus.signal1red == true)
                {
                    speed = 0;
                }
                else
                {
                    speed = 4;
                }
            }
            
            if (transform.position == (wayPointList[1].position))
            {
                if(signalstatus.signal2red == true)
                {
                    speed = 0;
                }
                else
                {
                    speed = 4;
                }
            }           
        }
        else
        {
            currentWayPoint = 0;
        }
    }

	// moving object

    void walk()
    {
        transform.forward = Vector3.RotateTowards(transform.forward, (targetWayPoint.position - transform.position), speed * Time.deltaTime, 0.0f);

        transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position, speed * Time.deltaTime);

        if (transform.position == targetWayPoint.position)
        {
            if (currentWayPoint < this.wayPointList.Length)
            {
                currentWayPoint++;
            }
            targetWayPoint = wayPointList[currentWayPoint];
        }
    }
}
