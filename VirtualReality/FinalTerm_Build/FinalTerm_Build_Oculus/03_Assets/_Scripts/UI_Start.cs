using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Start : MonoBehaviour
{
    public GameObject ui;
    private void Start()
    {
        ui.SetActive(true);
    }

    private void Update()
    {
        //if (Input.GetKeyDown("u"))
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            ui.SetActive(false);
        }
    }
}