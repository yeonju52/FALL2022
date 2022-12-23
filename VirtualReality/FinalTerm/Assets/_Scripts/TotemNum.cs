using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotemNum : MonoBehaviour
{
    public int totemNum = 4;
    //transform.childCount
    private void Update()
    {
        totemNum = transform.childCount;
    }
}
