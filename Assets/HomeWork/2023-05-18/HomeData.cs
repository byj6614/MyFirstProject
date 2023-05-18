using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HomeData : MonoBehaviour
{
    [SerializeField]
    private int shootCount;

    public UnityAction<int> OnShootChanged;

    public void AddCount(int count)
    {
        shootCount += count;
        OnShootChanged?.Invoke(shootCount);
    }    
}
