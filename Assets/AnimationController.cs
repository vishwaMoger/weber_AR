using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnimationController : MonoBehaviour
{
   public GameObject[] models; // Array to hold the models
    private int currentModelIndex = 0; // To keep track of the current model
    public Button nextButton; // Reference to the next button
    //public Button previousButton; // Reference to the previous button
    public Button replayButton; // Reference to the replay button

    void Start()
    {
        // Ensure all models' animators are not playing any animations initially
        foreach (GameObject model in models)
        {
            model.GetComponent<Animator>().enabled = false;
        }

        // Add listeners to the buttons
        nextButton.onClick.AddListener(PlayNextAnimation);
        //previousButton.onClick.AddListener(PlayPreviousAnimation);
        replayButton.onClick.AddListener(ReplayCurrentAnimation);

        // Disable previous button initially since we're at the first animation
        //previousButton.interactable = false;
    }

    void PlayNextAnimation()
    {
        if (currentModelIndex < models.Length)
        {
            // if (currentModelIndex > 0)
            // {
            //     // Disable the animator of the previous model
            //     models[currentModelIndex - 1].GetComponent<Animator>().enabled = false;
            // }

            // Enable the animator of the current model and play the animation
            Animator animator = models[currentModelIndex].GetComponent<Animator>();
            animator.enabled = true;

            // Move to the next model for the next button click
            currentModelIndex++;

            // Enable the previous button since we're no longer at the first animation
            //previousButton.interactable = true;

            // Disable the next button if we're at the last animation
            if (currentModelIndex == models.Length)
            {
                nextButton.interactable = false;
            }
        }
    }

    void PlayPreviousAnimation()
    {
        if (currentModelIndex > 1)
        {
            // Disable the animator of the current model
            models[currentModelIndex - 1].GetComponent<Animator>().enabled = false;

            // Move to the previous model
            currentModelIndex--;

            // Enable the animator of the previous model and play the animation
            Animator animator = models[currentModelIndex - 1].GetComponent<Animator>();
            animator.enabled = true;

            // Enable the next button since we're no longer at the last animation
            nextButton.interactable = true;
        }
        else if (currentModelIndex == 1)
        {
            // Disable the animator of the first model
            models[currentModelIndex - 1].GetComponent<Animator>().enabled = false;

            // Move to the first model
            currentModelIndex--;

            // Enable the animator of the first model and play the animation
            Animator animator = models[currentModelIndex].GetComponent<Animator>();
            animator.enabled = true;

            // Disable the previous button since we're at the first animation
           // previousButton.interactable = false;

            // Enable the next button
            nextButton.interactable = true;
        }
    }

    void ReplayCurrentAnimation()
    {
        if (currentModelIndex > 0)
        {
            // Get the animator of the current model
            Animator animator = models[currentModelIndex - 1].GetComponent<Animator>();

            // Restart the animation
            animator.Play(animator.GetCurrentAnimatorStateInfo(0).fullPathHash, -1, 0f);
        }
        else
        {
            Debug.Log("No animation to replay.");
        }
    }

}
