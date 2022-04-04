using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scPlayerNumberInput : MonoBehaviour
{
	public SpriteRenderer yourButton;
    private void Awake()
    {
       
        OnMouseDown();
    }

    void OnMouseDown()
    {
        Debug.Log("You have clicked the button!");
    }

}
