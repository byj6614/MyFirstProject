using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankTransform : MonoBehaviour
{
    private Vector3 TankDir;
    private Vector3 rotateDir;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;
    [Header("Shooter")]
    //�Ѿ��� �߻���ġ�� �����ϰ� �Ѿ��� ������ ���Ѱ�
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private float bulletTime;

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

    private Coroutine bulletRoutine;
    private void OnFire()
    {
        Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
    }

    IEnumerator BulletMakeRoutine()
    {
        while(true)
        {
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            //          �Ѿ˻���     ,       ���� ��ġ,            ���� ȸ��
            yield return new WaitForSeconds(bulletTime);
        }
    }

    private void OnRepeatFire(InputValue Value)
    {
        if(Value.isPressed)
        {
            bulletRoutine=StartCoroutine(BulletMakeRoutine());
        }
        else
        {
            StopCoroutine(bulletRoutine);
        }
    }
}

