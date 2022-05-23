using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Sword_trigger_zone : MonoBehaviour
{

    public GameObject originalSword;
    public GameObject swordPlaced;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Epee"))
        {
            Debug.Log("Sword is in the box");
            //originalSword.SetActive(false);
            swordPlaced.SetActive(true);
            
        }
    }
}



