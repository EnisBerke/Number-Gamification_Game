using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scObjectSpawner : MonoBehaviour
{
    public GameObject applePrefab;

    public float Delay = 3f;


    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    
    void Update()
    {
        
    }

    IEnumerator SpawnObject()
    {
        while (true)
        {
            float randomXPosition = Random.Range(1f, 1f);
            Vector3 spawnPosition = new Vector3(x: randomXPosition, y: 1.05f, z: 0);
            Instantiate(applePrefab, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(Delay);
        }
    }
}
