using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scFiveNumberIndex : MonoBehaviour
{
    //public GameObject Index;

    void Start()
    {

    }

    void Update()
    {
        //Index = GameObject.FindWithTag("one");


        //ScoreValue = GameObject.FindWithTag("apple").GetComponent<scApple>().score;
        Debug.Log(scGameManager.ScoreValue);

    }

    public void OnMouseDown()
    {
        if (scObjectSpawner.timeToStop < Time.time)
        {
            if (scGameManager.ScoreValue == 5)
            {
                Debug.Log("Correct Answer");
            }
        }
    }
}
