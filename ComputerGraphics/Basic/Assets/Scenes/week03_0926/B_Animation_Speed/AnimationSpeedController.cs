using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeedController : MonoBehaviour
{
    Animator Anim;
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0f;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Anim.speed = 1.0f;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Anim.speed = 2.0f;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Anim.speed = 0f;
        }
    }
}
