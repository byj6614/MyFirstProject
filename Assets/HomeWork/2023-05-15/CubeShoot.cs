using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CubeShoot : MonoBehaviour
{
    [SerializeField] private HomeShell homeShell;
    [SerializeField] private Transform cubePoint;
    [SerializeField] private float shellTime;
    
    private void OnFire()
    {
        Instantiate(homeShell, cubePoint.position, cubePoint.rotation);
    }
    private Coroutine shellRoutine;
    IEnumerator BulletMakeRoutine()
    {
        while (true)
        {
            Instantiate(homeShell, cubePoint.position, cubePoint.rotation);
            //          총알생성     ,       만들 위치,            만들 회전
            yield return new WaitForSeconds(shellTime);
        }
    }

    private void OnRefeatShoot(InputValue Value)
    {
        if (Value.isPressed)
        {
            shellRoutine = StartCoroutine(BulletMakeRoutine());
        }
        else
        {
            StopCoroutine(shellRoutine);
        }
    }
}

