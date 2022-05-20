using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Lever_Mecanism : MonoBehaviour
{
    public XRGrabInteractable grab;
    public GameObject sword;
    public Vector3 swordSpaceSettings = new Vector3(0f, 0f, 0f);


    private void OnEnable()
    {
        grab.selectEntered.AddListener(SwordPosition);
        
    }

    private void OnDisable()
    {
        grab.selectEntered.AddListener(SwordPosition);
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Poignee"))
        {
            sword.SetActive(true);
            //SwordPosition?.Invoke();

        }
    }

    public void SwordPosition(SelectEnterEventArgs args)
    {
        sword.transform.position = sword.transform.position + swordSpaceSettings;
    }
    
    
}
