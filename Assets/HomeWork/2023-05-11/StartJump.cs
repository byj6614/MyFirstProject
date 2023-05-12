using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartJump : MonoBehaviour
{
    public Rigidbody rb;
    public int a=5;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * a, ForceMode.Impulse);
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(Vector3.up * a, ForceMode.Impulse);
    }
}
