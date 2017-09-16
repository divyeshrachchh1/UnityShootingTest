using UnityEngine;
using System.Collections;

public class ZombieController : MonoBehaviour {
    float zombie1generatetime = 3.0f; // time to generate zombie 
    bool zombie1generateflag = true;  // to stop or start generation of zombie
    public GameObject zombie1pre;     
    int zombie1nocount;               // number of zombies generated

	float zombie2generatetime = 4.0f;// time to generate zombie 
    bool zombie2generateflag = true;
    public GameObject zombie2pre;
    int zombie2nocount;

	float zombie3generatetime = 2.0f;// time to generate zombie 
    bool zombie3generateflag = true;
    public GameObject zombie3pre;
    int zombie3nocount;

	float zombie4generatetime = 1.0f;// time to generate zombie 
    bool zombie4generateflag = true;
    public GameObject zombie4pre;
    int zombie4nocount;

    int tenzombiespawn; // check total number of zombies generated 
    bool spawnredzombie;
    public GameObject zombiered;

    // Use this for initialization
    void Start () {
        tenzombiespawn = 0;

        zombie1nocount = 0;
        StartCoroutine(Zombie1Generator());

        zombie2nocount = 0;
        StartCoroutine(Zombie2Generator());

        zombie3nocount = 0;
        StartCoroutine(Zombie3Generator());

        zombie4nocount = 0;
        StartCoroutine(Zombie4Generator());
        spawnredzombie = false;
    }
    IEnumerator Zombie1Generator()
    {
        while (zombie1generateflag)
        {
            GameObject go = (GameObject)Instantiate(zombie1pre);
            go.name = "Zombie1"+ zombie1nocount.ToString();
            zombie1nocount++;
            tenzombiespawn++;
            yield return new WaitForSeconds(zombie1generatetime);
            // to generate only five zombies...
			/*if (zombie1nocount >= 5)
            {
                zombie1generateflag = false;
            }*/
        }

    }
    IEnumerator Zombie2Generator()
    {
        while (zombie2generateflag)
        {
            GameObject go = (GameObject)Instantiate(zombie2pre);
            go.name = "Zombie2" + zombie2nocount.ToString();
            zombie2nocount++;
            tenzombiespawn++;

            yield return new WaitForSeconds(zombie2generatetime);
			// to generate only five zombies...
           /* if (zombie2nocount >= 5)
            {
                zombie2generateflag = false;
            }*/
        }

    }
    IEnumerator Zombie3Generator()
    {
        while (zombie3generateflag)
        {
            GameObject go = (GameObject)Instantiate(zombie3pre);
            go.name = "Zombie3" + zombie3nocount.ToString();
            zombie3nocount++;
            tenzombiespawn++;

           yield return new WaitForSeconds(zombie3generatetime);
			// to generate only five zombies...
			/*  if (zombie3nocount >= 5)
            {
                zombie3generateflag = false;
            }*/
        }

    }
    IEnumerator Zombie4Generator()
    {
        while (zombie4generateflag)
        {
            GameObject go = (GameObject)Instantiate(zombie4pre);
            go.name = "Zombie4" + zombie4nocount.ToString();
            zombie4nocount++;
            tenzombiespawn++;

            yield return new WaitForSeconds(zombie4generatetime);
			// to generate only five zombies...
            /*if (zombie4nocount >= 5)
            {
                zombie4generateflag = false;
            }*/
        }

    }

    IEnumerator RedZombieGenerator()
    {
            
            GameObject go = (GameObject)Instantiate(zombiered);
             go.name = "Redzombie";
        spawnredzombie = false;
        yield return new WaitForSeconds(0.1f);
           
       

    }
    // Update is called once per frame
    void Update () {

		//generate red crazy zombie from table
        if (tenzombiespawn >= 10 )
        {
            if(spawnredzombie == false) {
                spawnredzombie = true;
                tenzombiespawn = 0;
                StartCoroutine(RedZombieGenerator());
            }

        }
	}
}
