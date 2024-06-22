using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
    public GameObject Hotspot_label;
    public bool isSelected = false;

    // Start is called before the first frame update
    void Start()
    {
         Hotspot_label.SetActive(false);
    }

    public void ToggleObjectSelection()
    {
         // Toggle the selection state
        isSelected = !isSelected;

        // Apply the selection/deselection logic
        if (isSelected)
        {
            Hotspot_label.SetActive(true);
        }
        else
        {
            Hotspot_label.SetActive(false);
        }
    }
}
