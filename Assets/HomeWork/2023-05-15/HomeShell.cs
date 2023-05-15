using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeShell : MonoBehaviour
{
    [SerializeField] private float shellSpeed;
    private Rigidbody shellRb;


    private void Awake()
    {
        shellRb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        shellRb.velocity = transform.forward * shellSpeed;
        Destroy(gameObject, 5f);
    }
}
