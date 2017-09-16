using UnityEngine;
using System.Collections;

public class HandleSignal : MonoBehaviour {
    float resetTime = 5.0f;

    public bool signal1red = false;
    public bool signal2red = false;
    public bool signal3red = false;
    public bool signal4red = false;
    // Use this for initialization
    void Start () {

        StartCoroutine(startsignals());
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator startsignals()
    {
        StartCoroutine(signal1());
        //Debug.Log("startsignal1");
        yield return new WaitForSeconds(Random.Range(1, 3));
        StartCoroutine(signal2());

        // Debug.Log("startsignal2");
        yield return new WaitForSeconds(Random.Range(2, 4));
        StartCoroutine(signal3());

        //  Debug.Log("startsignal3");
        yield return new WaitForSeconds(Random.Range(3, 5));
        StartCoroutine(signal4());

        //  Debug.Log("startsignal4");




    }
    IEnumerator signal1()
    {
        while (true)
        {
            // Debug.Log("green");
            //cubeLight.color = Color.blue;
            signal1red = false;
            GameObject.Find("signal1").GetComponent<Renderer>().material.color = new Color(0, 255, 0);
            yield return new WaitForSeconds(resetTime);
            //cubeLight.color = Color.red;
            signal1red = true;
            GameObject.Find("signal1").GetComponent<Renderer>().material.color = new Color(255, 0, 0);

            //Debug.Log("red");
            yield return new WaitForSeconds(resetTime);
        }

    }
    IEnumerator signal2()
    {
        while (true)
        {
            //Debug.Log("green");
            //cubeLight.color = Color.blue;
            signal2red = false;
            GameObject.Find("signal2").GetComponent<Renderer>().material.color = new Color(0, 255, 0);
            yield return new WaitForSeconds(resetTime);
            //cubeLight.color = Color.red;
            signal2red = true;
            GameObject.Find("signal2").GetComponent<Renderer>().material.color = new Color(255, 0, 0);

            //Debug.Log("red");
            yield return new WaitForSeconds(resetTime);
        }

    }
    IEnumerator signal3()
    {
        while (true)
        {
            // Debug.Log("green");
            //cubeLight.color = Color.blue;
            signal3red = false;
            GameObject.Find("signal3").GetComponent<Renderer>().material.color = new Color(0, 255, 0);
            yield return new WaitForSeconds(resetTime);
            //cubeLight.color = Color.red;
            signal3red = true;
            GameObject.Find("signal3").GetComponent<Renderer>().material.color = new Color(255, 0, 0);

            //Debug.Log("red");
            yield return new WaitForSeconds(resetTime);
        }

    }
    IEnumerator signal4()
    {
        while (true)
        {
            //Debug.Log("green");
            //cubeLight.color = Color.blue;
            signal4red = false;
            GameObject.Find("signal4").GetComponent<Renderer>().material.color = new Color(0, 255, 0);
            yield return new WaitForSeconds(resetTime);
            //cubeLight.color = Color.red;
            signal4red = true;
            GameObject.Find("signal4").GetComponent<Renderer>().material.color = new Color(255, 0, 0);

            //Debug.Log("red");
            yield return new WaitForSeconds(resetTime);
        }

    }
}
