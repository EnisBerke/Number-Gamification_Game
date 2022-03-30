using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scNumberSpawner : MonoBehaviour
{
    
    public GameObject NumberPrefab;
    public Sprite[] NumberSprites;
    
    
    void Start()
    {
        
      GameObject newNumbers = Instantiate(NumberPrefab);
      
    }

    void Update()
    {

    }

    
    
}


    
    
