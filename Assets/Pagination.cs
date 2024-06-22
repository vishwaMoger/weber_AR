using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pagination : MonoBehaviour
{
    public GameObject[] Pagebjects;
    public Button PrevButton;
    public Button NextButton;

    public int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Initialize: Enable the first object and disable the rest
        UpdateGameObjects();

        // Add listeners to the buttons
        NextButton.onClick.AddListener(NextObject);
        PrevButton.onClick.AddListener(PreviousObject);
    }

    void NextObject()
    {
        if (currentIndex < Pagebjects.Length - 1)
        {
            currentIndex++;
            UpdateGameObjects();
        }
    }

    void PreviousObject()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            UpdateGameObjects();
        }
    }

    void UpdateGameObjects()
    {
        for (int i = 0; i < Pagebjects.Length; i++)
        {
            Pagebjects[i].SetActive(i == currentIndex);
        }
    }
}
