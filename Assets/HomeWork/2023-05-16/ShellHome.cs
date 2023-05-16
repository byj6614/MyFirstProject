using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellHome : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private GameObject explosionEffect;
    public AudioClip collisionSound;
    private Rigidbody rb;
    private AudioSource aos;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        aos = GetComponent<AudioSource>();
    }

    private void Start()
    {
        rb.velocity = transform.forward* bulletSpeed;
        Destroy(gameObject, 5f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        Instantiate(explosionEffect, transform.position, transform.rotation);
        AudioSource.PlayClipAtPoint(collisionSound, collision.contacts[0].point);
        Destroy(gameObject);
    }
}
