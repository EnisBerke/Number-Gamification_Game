using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        

        if(collision.transform.name == "apple")
        {
            score += 1;
            Debug.Log("accapted");
            Destroy(gameObject);
        }
    }
}
