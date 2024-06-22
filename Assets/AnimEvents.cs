using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimEvents : MonoBehaviour
{
    public GameObject UpButton;
    public GameObject CloseButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpAnimEvent()
    {
        CloseButton.SetActive(true);
    }

    public void DownAnimEvent()
    {
        UpButton.SetActive(true);
    }

    public void ExitYesButton()
    {
        Application.Quit();
    }
}
