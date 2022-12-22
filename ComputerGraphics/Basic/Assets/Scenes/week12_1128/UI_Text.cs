using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Text : MonoBehaviour
{
    public GameObject MyObject;
    
    void Start()
    {
        string name = MyObject.name;
        GetComponent<Text>().text = name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
