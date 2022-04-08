using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scAlertBox : MonoBehaviour
{

    public GameObject popUpBox;
    public Animator animator;
    public TMP_Text popUpText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        popUpText.text = text;
        animator.SetTrigger("Correct Answer");
    }
}
