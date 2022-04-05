using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc8NumberIndex : MonoBehaviour
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
            if (scGameManager.ScoreValue == 8)
            {
                Debug.Log("Correct Answer");
            }
        }
    }
}
