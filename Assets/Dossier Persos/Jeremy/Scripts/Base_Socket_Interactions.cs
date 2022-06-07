using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Base_Socket_Interactions : MonoBehaviour
{
    [SerializeField] XRSocketInteractor snap;
    public GameObject doorTrap;
    public bool snapOn = true;
    
    
    private void OnEnable()
    {
        snap.selectEntered.AddListener(StartSnap);
        snap.selectExited.AddListener(StopSnap);
        
    }

    private void OnDisable()
    {
        snap.selectEntered.RemoveListener(StartSnap);
        snap.selectExited.RemoveListener(StopSnap);
    }


    private void Start()
    {
        snapOn = false;
        
    }

    public void StartSnap(SelectEnterEventArgs args)
    {
        
        snapOn = true;
        
        
        if (snap == true)
        {
            doorTrap.SetActive(false);
            
            
        }
        
    }
    
    public void StopSnap(SelectExitEventArgs args)
    {
        snapOn = false;
        
        if (!snapOn)
        {
            doorTrap.SetActive(true);
            
        }
        
    }
}
