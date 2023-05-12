using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankTransform : MonoBehaviour
{
    private Vector3 TankDir;
    private Vector3 rotateDir;

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float jumpPower;
    [SerializeField]
    private float rotateSpeed;

    private void Update()
    {
        Move();
        RotateUp();
    }

    private void RotateUp()
    {
        transform.Rotate(Vector3.up, TankDir.x * rotateSpeed * Time.deltaTime);
    }
    private void Move()
    {
        transform.Translate(Vector3.forward* TankDir.z*moveSpeed*Time.deltaTime);
    }



    private void OnMove(InputValue Value)
    {
        TankDir.x = Value.Get<Vector2>().x;
        TankDir.z = Value.Get<Vector2>().y;
    }

}

