using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scNumberSpawner : MonoBehaviour
{
    
    public GameObject NumberPrefab;
    public Sprite[] NumberSprites;
    public float x;
    public float y;
    
    
    void Start()
    {
        x = -7.5f;
        y = 3.7f;
        GameObject newNumbers = Instantiate(NumberPrefab);
        for (int i = 0; i < 9; i++)
        {
            newNumbers.transform.GetChild(i).gameObject.transform.position = new Vector3(x,y,0);
            x += 1.6f;
            if (i == 2)
            {
                y -= 1.8f;
                x = -7.5f;
            }

            else if (i == 5)
            {
                y -= 1.8f;
                x = -7.5f;
            }
        }
    }

    void Update()
    {

    }

    
    
}


    
    
