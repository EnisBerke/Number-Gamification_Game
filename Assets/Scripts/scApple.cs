using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scApple : MonoBehaviour
{
    internal object score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        
       float score = ++scGameManager.Instance.Score;

        Debug.Log("Score: " + score);


        //Destroy(other.gameObject);
    }
}
