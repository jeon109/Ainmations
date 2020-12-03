using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaterController2DFreeformC : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);

        //float moveSpeed = 0.5f;
        //transform.position += new Vertor3(horizontal,0,vertical) *moveSpeed*Time.deltaTima;
    }
}
