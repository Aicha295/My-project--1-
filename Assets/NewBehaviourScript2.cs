using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    public GameObject[] spawns;
    float timeBtwSpawns = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeBtwSpawns -= Time.deltaTime;
        if (timeBtwSpawns <= 0)
        {
            timeBtwSpawns =Random.Range(4.5f,2.5f);
            Vector2 spawnposition = new Vector2();
            spawnposition.x = Random.Range(-1.5f, 1.5f);
            spawnposition.y = -7;
            Instantiate(spawns[Random.Range(0, spawns.Length)], spawnposition, Quaternion.identity);
        }
    }
}
