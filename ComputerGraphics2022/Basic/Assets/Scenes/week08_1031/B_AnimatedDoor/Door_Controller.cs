using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Controller : MonoBehaviour
{
    public GameObject Pivot;

    private void OnTriggerEnter(Collider other)
    {
        print("enter " + other.name);
        Pivot.GetComponent<Animator>().SetInteger("State", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        print("exit " + other.name);
        Pivot.GetComponent<Animator>().SetInteger("State", 2);
    }
}


////부딪히면, collider 통과 못함 - isTrigger 표시 안 되어 있음
//private void OnCollisionEnter(Collision collision)
//{
//    print(collision.gameObject.name);
//}
