using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSlider : MonoBehaviour
{
    float bottomY = -2.5F;

    

    void Start()
    {
        
    }

    
    void Update()
    {
        if ( transform.position.y < bottomY)
        {
            Destroy(gameObject);
        }
    }
}
