using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject Light;
    bool isOn;

    void Start()
    {
        isOn = false;
        Light.SetActive(isOn);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            print("L down");
            print(Light.name);

            isOn = !isOn;
            Light.SetActive(isOn);
        }
    }

    private void OnMouseDown()
    {
        print(gameObject.name + " mouse down");
        isOn = !isOn;
        Light.SetActive(isOn);
    }
}
