using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HomeAddforce : MonoBehaviour
{
    private Vector3 ballDir;
    private Rigidbody rb;

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float jumpPower;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
    }
    public void Move()
    {
        rb.AddForce(Vector3.forward*ballDir.x*moveSpeed);
        rb.AddForce(Vector3.left * ballDir.z * moveSpeed);
    }
    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        
    }
    private void OnMove(InputValue value)
    {
        ballDir.x = value.Get<Vector2>().x;
        ballDir.z = value.Get<Vector2>().y;
    }

    private void OnJump(InputValue Value)
    {
        Jump();
    }
}
