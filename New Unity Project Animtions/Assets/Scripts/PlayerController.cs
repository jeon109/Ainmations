using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //  animator.Play("Idle");
            animator.SetFloat("MoveSpeed", 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            //   animator.Play("RUN00_F");
            animator.SetFloat("MoveSpeed", 5.0f);
        }
    }
}
