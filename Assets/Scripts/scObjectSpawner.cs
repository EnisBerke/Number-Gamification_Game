using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scObjectSpawner : MonoBehaviour
{
    public GameObject applePrefab;
    public float spawnTime;
    public float minTime;
    public float maxTime;
    public float Delay = 3f;
    public float timeToStop;
    public float timePassed;
    
    

    void Start()
    {
        StartCoroutine(SpawnObject());

        
    }

    
    void Update()
    {
        
    }




    private void Awake()
    {
        spawnTime = Random.Range(minTime, maxTime);
        Debug.Log("spawnTime: "+ spawnTime);

       


    }

    IEnumerator SpawnObject()
    {
        while (timePassed<timeToStop)
        {
            float randomXPosition = Random.Range(1f, 1f);
            Vector3 spawnPosition = new Vector3(x: randomXPosition, y: 1.05f, z: 0);
            Instantiate(applePrefab, spawnPosition, Quaternion.identity);
            timePassed = timePassed + spawnTime;
            Debug.Log("timePassed: " + timePassed);
            yield return new WaitForSeconds(spawnTime);
        }
    }

   


}
