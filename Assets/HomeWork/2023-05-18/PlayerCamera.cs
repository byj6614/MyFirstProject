using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera focuseCam;

    public void OnZoomin(InputValue value)
    {
        if (value.isPressed)
        {
            
            focuseCam.Priority = 999;
        }
        else
        {
            
            focuseCam.Priority = 0;
        }
    }
}
