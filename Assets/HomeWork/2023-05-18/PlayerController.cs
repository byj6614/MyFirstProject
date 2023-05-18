using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public UnityEvent OnFired;
    public UnityEvent OnMoved;

    private void Fire()
    {
        OnFired?.Invoke();
    }
    private void Move()
    {
        OnMoved?.Invoke();
    }
}
