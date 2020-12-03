using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2DFreeFormD : MonoBehaviour
{
    private Animator animator;
    //private float walkSpeed = 4.0f;
    //private float runSpreed = 8.0f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float offset = 0.5f + Input.GetAxis("Sprint") * 0.5f;

        animator.SetFloat("Horizontal", horizontal * offset);
        animator.SetFloat("Vertical", vertical * offset);

        //float moveSpeed = 0.5f;
        //transform.position += new Vertor3(horizontal,0,vertical) *moveSpeed*Time.deltaTima;
    }
}
