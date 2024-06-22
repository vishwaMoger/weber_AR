using System.Collections;
using System.Collections.Generic;
//using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class NumBUtton : MonoBehaviour
{
    public ImageManager ImgManager;
    public GameObject[] images;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateIndexNumbers(int Img_index)
    {
        ImgManager.currentImageIndex = Img_index;
        // if(ImgManager.images[ImgManager.currentImageIndex].CompareTag("Animated"))
        // {
        //     ImgManager.currentModelIndex --;
        // }

        for(int i = 0; i <= images.Length-1; i++)
        {
            images[i].SetActive(false);
        }
        images[ImgManager.currentImageIndex-1].SetActive(true);

         if(ImgManager.currentImageIndex >= 1)
        {
            // Enable the previous button since we're no longer at the first image
            ImgManager.previousButton.interactable = true;
        }
    }

    public void UpdateModelNumber(int modelIndx)
    {
        ImgManager.currentModelIndex = modelIndx;
        
    }

    public void close_Subtitle()
    {
        if(ImgManager.Subtitle_Texts[ImgManager.currentImageIndex] == ImgManager.Subtitle_Texts[0])
        {
            ImgManager.Subtitle_Texts[0].SetActive(false);
            
        }else
        {
            ImgManager.Subtitle_Texts[ImgManager.currentImageIndex-1].SetActive(false);
        }
    }
}
