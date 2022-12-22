using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TMP_Text log;
    GameObject player;
    public string[] dialog;
    int turn;

    void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown("e") && other.tag == "Player")
        {
            player = other.gameObject;
            player.GetComponent<Rigidbody>().isKinematic = true;
            Dialogread();
        }
    }
    public void Dialogread()
    {
        if(turn < dialog.Length)
        {
            log.text = dialog[turn];
            turn++;
        }
        else
        {
            player.GetComponent<Rigidbody>().isKinematic = false;
            turn = 0;
        }
    }
}
