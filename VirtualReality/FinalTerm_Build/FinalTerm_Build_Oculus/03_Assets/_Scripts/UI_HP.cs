using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_HP : MonoBehaviour
{
    public Text myHP;
    public int HP; // ���� hp�� �ִ� �����Դϴ�.

    void Start() // ó�� ������ �� ǥ���մϴ�.
    {
        HP = GetComponent<EnemyDamaged>().HP; // hp�� �����ͼ� hp������ �ֽ��ϴ�.
        myHP.text = "HP:" + HP.ToString(); //UI�ؽ�Ʈ�� HP : ��� ������ �ְ� hp������ ����(string)���� ��ȯ�� �߰��մϴ�. 
    }

    private void OnTriggerEnter(Collider col) //�浹�� ��� ���� �����մϴ�. 
    {
        //Debug.Log("Trigger");
        if (col.gameObject.tag == "Grabbable")
        {
            HP = GetComponent<EnemyDamaged>().HP; // ���� �����ϵ� �浹�� �߻��� ���� �����մϴ�.
            myHP.text = "HP:" + HP.ToString();
            //Debug.Log(HP.ToString());
        }
    }
}
