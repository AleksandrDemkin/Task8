using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class AnimControl : MonoBehaviour
{
    private Animator animator;

    public float vertical;
    public float horizontal;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        if (vertical == 0)
        {
            animator.SetBool("RunForward", false);
        }

        if (vertical >= 0.1f)
        {
            animator.SetBool("RunForward", true);
        }
    }

}
