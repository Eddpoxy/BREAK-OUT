using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class jumpscare : MonoBehaviour
{
    public ball ballScript; // Drag and drop the GameObject with the Ball script here in the Unity Editor

    void Start()
    {
       

    }

    void Update()
    {
      
        if (ballScript.GameOver == true)
        {
            Debug.Log("k");
            gameObject.transform.position += new Vector3(0, 0, -3); 
            if (gameObject.transform.position.z <= -10.2)
            {
                ballScript.GameOver = false;
                
            }
        }
    }
}

