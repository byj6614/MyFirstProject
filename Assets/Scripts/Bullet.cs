using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private GameObject explosionEffect;
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    /************************************************************************
	 * 트리거 충돌체
	 * 
	 * 하나의 충돌체가 충돌을 일으키지 않고 다른 충돌체의 공간에 들어가는 것을 감지
	 * 트리거가 겹침상황에 있을 경우 유니티 트리거 메시지를 받아 상황을 확인
	 ************************************************************************/

   
}
