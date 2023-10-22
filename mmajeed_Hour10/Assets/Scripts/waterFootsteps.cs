using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterFootsteps : MonoBehaviour
{
    public AudioSource watersteps;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                watersteps.enabled = true;
            }
            else
            {
                watersteps.enabled = false;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            watersteps.enabled = false;
        }
    }
}