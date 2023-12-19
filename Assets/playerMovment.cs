using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerMovment : MonoBehaviour
{
    [SerializeField]
    float speed = 10;
    Rigidbody rb;
    // Start is called before the first frame update 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(speed, 0, 0), ForceMode.Impulse);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-speed, 0, 0), ForceMode.Impulse);
        }

    }
}
