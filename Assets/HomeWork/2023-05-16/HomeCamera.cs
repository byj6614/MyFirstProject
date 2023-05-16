using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HomeCamera : MonoBehaviour
{
   
    [SerializeField] private CinemachineVirtualCamera focuseCam;

    private void OnZoomin(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("OnFocused");
            focuseCam.Priority = 999;
        }
        else
        {
            Debug.Log("OnUnFocused");
            focuseCam.Priority = 0;
        }
    }
}
