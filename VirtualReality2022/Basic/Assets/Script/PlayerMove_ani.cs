using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_ani : MonoBehaviour
{
    public int Speed = 2;
    public float RotateX = 15.0f;
    Animator animator; //�ִϸ����͸� ����ϴ� ������ �߰��Ͽ����ϴ�.

    void Start()
    {
        this.animator = GetComponent<Animator>();
        //���۰� ���ÿ� �ش� ��ü���� ��ϵ� �ִϸ�����������Ʈ�� �ҷ��� �ִϸ����� ������ �ֽ��ϴ�.
    }

    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * RotateX, 0);

        float keyHorizontal = Input.GetAxis("Horizontal");
        float keyVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Speed * Time.smoothDeltaTime * keyHorizontal);
        transform.Translate(Vector3.forward * Speed * Time.smoothDeltaTime * keyVertical);

        this.animator.SetFloat("Xchuk", keyHorizontal);
        this.animator.SetFloat("Zchuk", keyVertical);
        //�ִϸ����� ���� �� x�� y�� �����̵带 Ű�Է°� �����մϴ�.
    }
}
