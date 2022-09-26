using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMultiplierController : MonoBehaviour
{    
    Animator Anim;
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.SetFloat("Dir", 0f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Anim.SetFloat("Dir", 1f);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Anim.SetFloat("Dir", -1f);      // 역재생 가능
        }

        if (Input.GetKeyDown(KeyCode.S))
        {            
            Anim.SetFloat("Dir", 0f);
        }
    }
}
