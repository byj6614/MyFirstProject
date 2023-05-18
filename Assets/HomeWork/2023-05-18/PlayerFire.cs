using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletPoint;

    public UnityEvent FireSounded;
    
    public void OnFire()
    {
        Instantiate(bullet, bulletPoint.position, bulletPoint.rotation);
        GameManager.Data.AddShootCount(1);
        FireSounded?.Invoke();
    }
}
