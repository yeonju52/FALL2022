using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Finish : MonoBehaviour
{
    public GameObject ui;

    void Start()
    {
        ui.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            ui.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ui.SetActive(false);
    }
}