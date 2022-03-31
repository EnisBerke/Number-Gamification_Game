using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scObjectSpawnTime : MonoBehaviour
{

    //Spawn this object
    public GameObject spawnObject;

    public float maxTime = 10;
    public float minTime = 3;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {
        float stopTime = 15;
        //Counts up
        for (time = 0; time < stopTime; time = time+(spawnTime*Time.deltaTime))
        {

        }
        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            
            SetRandomTime();
        }

    }

    private void Awake()
    {
        SetRandomTime();
    }

    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }


}




