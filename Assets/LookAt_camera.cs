using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt_camera : MonoBehaviour
{
   void Update()
    {
        // Make the UI object face the camera
        transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward,Camera.main.transform.rotation * Vector3.up);
    }
}
