using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCont : MonoBehaviour
{
    
    private Vector3 moveDir;

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float jumpPower;
    [SerializeField]
    private float rotateSpeed;


    private void Update()
    {
        Move();
        Rotate();
        //LookAt();
    }

    public void Jump()
    {
        
    }
    public void Move() 
    {
        transform.Translate(Vector3.forward * moveDir.z * moveSpeed * Time.deltaTime,Space.Self);
    }
    public void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x* rotateSpeed * Time.deltaTime);
    }

    public void LookAt()
    {
        transform.LookAt(new Vector3(0, 0, 0));
    }
    // <Quarternion & Euler>
    // Quarternion	: ����Ƽ�� ���ӿ�����Ʈ�� 3���� ������ �����ϰ� �̸� ���⿡�� �ٸ� ���������� ��� ȸ������ ����
    //				  �������� ȸ������ ������ ������ �߻����� ����
    // EulerAngle	: 3���� �������� ���������� ȸ����Ű�� ���
    //				  ������������ ������ ������ �߻��Ͽ� ȸ���� ��ġ�� ���� ���� �� ����
    // ������		: ���� �������� ������Ʈ�� �� ȸ�� ���� ��ġ�� ����

    // Quarternion�� ���� ȸ�������� ����ϴ� ���� ���������� �ʰ� �����ϱ� �����
    // ������ ��� ���ʹϾ� -> ���Ϸ����� -> �������� -> ������Ϸ����� -> ������ʹϾ� �� ���� ������ ��� ���ʹϾ��� �����
    public void Rotation()
    {
        // Ʈ�������� ȸ������ Euler���� ǥ���� �ƴ� Quaternion�� �����
        transform.rotation = Quaternion.identity;

        // Euler������ Quaternion���� ��ȯ
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }
    private void OnMove(InputValue Value)
    {
        moveDir.x=Value.Get<Vector2>().x;
        moveDir.z = Value.Get<Vector2>().y;
    }

    private void OnJump(InputValue Value)
    {
        Jump();
    }
}
