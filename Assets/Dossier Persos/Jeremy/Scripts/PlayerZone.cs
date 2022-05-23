using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerZone : MonoBehaviour
{
    public GameObject swordTriggerZone;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            swordTriggerZone.SetActive(true);
        }
    }
    
}
