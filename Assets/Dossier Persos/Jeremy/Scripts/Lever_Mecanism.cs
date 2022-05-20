using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever_Mecanism : MonoBehaviour
{
    public GameObject sword;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Poignee"))
        {
            sword.SetActive(true);
            
        }
    }
    
    
}
