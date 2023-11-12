using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Assuming 'animator' is your Animator component
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
           
        }
    }
}
