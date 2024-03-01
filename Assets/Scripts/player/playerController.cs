using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Rigidbody rb;
    void Update()
    {
        rb.AddForce(Vector3.forward * 1, ForceMode.Acceleration);
        if(Input.GetKey("a") | Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * 0.25f, ForceMode.Impulse);
        }
        if(Input.GetKey("d") | Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * 0.25f, ForceMode.Impulse);
        }
        if(Input.GetKey("s") | Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * 1.25f, ForceMode.Acceleration);
        }
        if((Input.GetKeyDown("w") | Input.GetKeyDown(KeyCode.UpArrow) | Input.GetKeyDown(KeyCode.Space)) && true)
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }
}
