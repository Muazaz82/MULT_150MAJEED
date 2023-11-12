using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAnimator : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for key presses and set trigger parameters accordingly
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("ColorChange");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Scale");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Spin");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Hover");
        }
    }
}
