using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Slider : MonoBehaviour
{
    public GameObject MyGameObject;
    Material MyMaterial;

    void Start()
    {
        MyMaterial = MyGameObject.GetComponent<Renderer>().material;
    }

    void Update()
    {
    }

    public void OnValueChanged_SetColor() //사용자 함수
    {
        float val = GetComponent<Slider>().value;
        print(val);
        Color c = new Color(val, val, val, 1);
        MyMaterial.SetColor("_Color", c);
    }
}
