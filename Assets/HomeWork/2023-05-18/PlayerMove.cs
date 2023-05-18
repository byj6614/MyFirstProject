using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;
    private Vector3 TankDir;

    public void Update()
    {
        Move();
        RotateUp();
    }
    public void RotateUp()
    {
        transform.Rotate(Vector3.up, TankDir.x * rotateSpeed * Time.deltaTime);
    }
    public void Move()
    {
        transform.Translate(Vector3.forward * TankDir.z * moveSpeed * Time.deltaTime);
    }
    private void OnMove(InputValue Value)
    {
        TankDir.x = Value.Get<Vector2>().x;
        TankDir.z = Value.Get<Vector2>().y;
    }
}
