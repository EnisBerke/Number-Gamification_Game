using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scGameManager : MonoBehaviour
{
    public static scGameManager Instance;

    public int Score;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
