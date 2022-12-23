using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DoorOpen : MonoBehaviour
{
    Animator animator;
    public float distance = 10f;
    public GameObject rayOrigin; //ray�� ���۵� �����Դϴ�. ���ӿ�����Ʈ�� �����ؼ� �־��ݽô�.
    public GameObject totem;
    int totemZero = 4;
    void Start()
    {
        this.animator = GetComponent<Animator>();
        totemZero = totem.GetComponent<TotemNum>().totemNum;
    }

    private void Update()
    {
        totemZero = totem.GetComponent<TotemNum>().totemNum;

        RaycastHit hit; // ray�� �浹ü�� �����մϴ�.
        if (totemZero == 0)
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            //���� ���ӿ�����Ʈ�� ���Ⱚ�� �����Ͽ� ����3������ ��Ÿ���ϴ�.
            Debug.DrawRay(rayOrigin.transform.position, fwd * distance, Color.red);
            //��â���� ���̰� ��� ������ �ִ��� �����ݴϴ�.
            if (Physics.Raycast(rayOrigin.transform.position, fwd, out hit, distance))
            {
                // �����Ÿ���ŭ ray�� �߻��Ͽ� �浹ü�� �����մϴ�.(out hit)
                // hit�� ���� �浹ü�� ��Ī�մϴ�.

                GameObject hitTarget = hit.collider.gameObject;
                //�浹ü�� ���ӿ�����Ʈ������ �����մϴ�.

                if (hitTarget.gameObject.tag == "Door") //�浹ü�� �±װ� Door���
                {
                    animator = hitTarget.gameObject.GetComponent<Animator>();
                    this.animator.SetTrigger("Key"); //�ִϸ��̼� Ʈ���� ��ȣ�� �����ϴ�.
                    totemZero--;
                }

            }
        }
    }

}


//public class OpenTheDoor : MonoBehaviour
//{
//    private Animator animator;
//    private int i = 0;

//    // Start is called before the first frame update
//    void Start()
//    {
//        animator = GetComponent<Animator>();
//    }

//    // Update is called once per frame
//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.tag == "Player")
//        {
//            animator.SetBool("Key", true);
//            Debug.Log("Key");
//            //animator.SetBool("Key", false);
//        }
//    }
//}


