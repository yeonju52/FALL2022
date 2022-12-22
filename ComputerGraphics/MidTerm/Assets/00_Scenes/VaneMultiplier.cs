using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaneMultiplier : MonoBehaviour
{
    Animator Anim;
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.SetFloat("Dir", 0f);
    }

    int d = 1;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Anim.SetFloat("Dir", 1f);
            d = 1;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Anim.SetFloat("Dir", -1f);      // 역재생 가능
            d = 1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Anim.SetFloat("Dir", 0f);
            d = 0;
        }
    }
    private void OnMouseDown()
    {
        Anim.SetFloat("Dir", 1f * d);
    }
}
