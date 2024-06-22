using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{
   public GameObject[] images; // Array to hold the images (GameObjects)
    public GameObject[] models; // Array to hold the models
    public int currentImageIndex = 0; // To keep track of the current image
    public int currentModelIndex = 0; // To keep track of the current model
    public Button nextButton; // Reference to the next button
    public Button previousButton; // Reference to the previous button
    public List<GameObject> Subtitle_Texts;
    public Button Caption_ONButton;
    public Button Caption_OFFButton;
    public GameObject Caption_ON_Obj;


    
    

    // public GameObject paginationParent; // Parent GameObject for pagination buttons
    // public Button paginationButtonPrefab; // Prefab for pagination buttons

    void Start()
    {
        // Disable all images initially
        foreach (GameObject image in images)
        {
            image.SetActive(false);
        }

        // Ensure all models' animators are not playing any animations initially
        foreach (GameObject model in models)
        {
            model.GetComponent<Animator>().enabled = false;
        }

         // Ensure all objects are initially disabled
        foreach (GameObject obj in Subtitle_Texts)
        {
            obj.SetActive(true);
        }

        //create pagination Buttons
        //CreatePaginationButtons();

        // Add listener to the next button
        nextButton.onClick.AddListener(Next);
        previousButton.onClick.AddListener(Previous);

        if (Caption_ONButton != null)
        {
            Caption_ONButton.onClick.AddListener(Toggle_ON_CurrentObject);
        }
        if (Caption_OFFButton != null)
        {
            Caption_OFFButton.onClick.AddListener(ToggleOFF_Object);
        }

        // Disable the previous button initially since we're at the first image
        previousButton.interactable = false;

        
    }

    // void CreatePaginationButtons()
    // {
        
    // }

    void Toggle_ON_CurrentObject()
    {
        // Disable all objects
        // foreach (var obj in Subtitle_Texts)
        // {
        //     obj.SetActive(false);
        // }

        // Enable the current object
        if (currentImageIndex >= 0 && currentImageIndex <= Subtitle_Texts.Count)
        {
           foreach (GameObject obj in Subtitle_Texts)
            {
                obj.SetActive(true);
            }
        }
    }
    void ToggleOFF_Object()
    {
        if (currentImageIndex >= 0 && currentImageIndex <= Subtitle_Texts.Count)
        {
            foreach (GameObject obj in Subtitle_Texts)
            {
                obj.SetActive(false);
            }   
        }
    }

    void Next()
    {
        
        // Check if we've reached the end of the images array
        if (currentImageIndex >= images.Length)
        {
            Debug.Log("No more images to display.");
            return;
        }

        // Disable the previous image if there is one
        if (currentImageIndex > 0)
        {
            images[currentImageIndex - 1].SetActive(false);
        }

        // Enable the current image
        images[currentImageIndex].SetActive(true);

        // If the current image has the "animated" tag, play the next animation
        if (images[currentImageIndex].CompareTag("Animated"))
        {
            models[currentModelIndex].SetActive(true);
            PlayNextAnimation();
        }

        // Move to the next image for the next button click
        currentImageIndex++;

        // if(currentImageIndex == 1)
        // {
        //     Caption_ON_Obj.SetActive(true);
        // }

        if(currentImageIndex >= 1)
        {
            // Enable the previous button since we're no longer at the first image
            previousButton.interactable = true;
        }
        
    }

    void Previous()
    {
        // Check if the current image index is within bounds
        if (currentImageIndex <= 0)
        {
            Debug.Log("No more images to display.");
            return;
        }

       
        // Move to the previous image
        currentImageIndex--;
        
        // Disable the current image
        images[currentImageIndex].SetActive(false);

        // Enable the previous image
        images[currentImageIndex - 1].SetActive(true);

        // If the previous image has the "animated" tag, reset and play the previous animation
        if (images[currentImageIndex - 1].CompareTag("Animated"))
        {
            currentModelIndex--;
            DisableFutureModels(currentModelIndex);
            ResetAndPlayAnimation(currentModelIndex-1);
        }

        // Disable the previous button if we've reached the first image
        if (currentImageIndex == 1 || currentImageIndex == 0 )
        {
            previousButton.interactable = false;
        }

        // Enable the next button since we are no longer at the end
        nextButton.interactable = true;
    }

    void PlayNextAnimation()
    {
        // Ensure we have models to play animations
        if (currentModelIndex < models.Length)
        {
            // Enable the animator of the current model and play the animation
            Animator animator = models[currentModelIndex].GetComponent<Animator>();
            animator.enabled = true;

            // Move to the next model for the next animated image
            currentModelIndex++;
        }
        else
        {
            Debug.Log("All animations have been played.");
        }
    }

   void ResetAndPlayAnimation(int modelIndex)
    {
        if (modelIndex < models.Length)
        {
            // Reset the animator of the model to its initial state
            Animator animator = models[modelIndex].GetComponent<Animator>();
            animator.Rebind();
            animator.Update(0f);

            // Enable the animator and play the animation from the start
            animator.enabled = true;
            animator.Play(animator.GetCurrentAnimatorStateInfo(0).fullPathHash, -1, 0f);
        }
    }
     void DisableFutureModels(int modelIndex)
    {
        if (modelIndex < models.Length)
        {
            models[modelIndex].SetActive(false);
        }
    }

  
}