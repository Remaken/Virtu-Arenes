using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_mecanism : MonoBehaviour
{
    
    public GameObject doorTrap;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Base"))
        {
            doorTrap.SetActive(false);
            
        }
    }
}
