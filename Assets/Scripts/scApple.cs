using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scApple : MonoBehaviour
{
    public float score;


    // Start is called before the first frame update
    void Start()
    {
        scGameManager.ScoreValue++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        
       score = ++scGameManager.Instance.Score;

        Debug.Log("Score: " + score);


        //Destroy(other.gameObject);
    }
}
