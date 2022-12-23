using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_UI : MonoBehaviour
{
    public GameObject ui;
    private int turn = 0;
    public GameObject check;
    //private AudioSource beep;

    void Start()
    {
        ui.SetActive(false);
        check.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            check.SetActive(true);
            //if (Input.GetKeyDown("u"))
            if (OVRInput.Get(OVRInput.Button.Two))
            {
                if (turn == 0)
                {
                    ui.SetActive(true);
                    turn = 1;
                }
                else
                {
                    ui.SetActive(false);
                    turn = 0;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ui.SetActive(false);
        check.SetActive(false);
        turn = 0;
    }
}