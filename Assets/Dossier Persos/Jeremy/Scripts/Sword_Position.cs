using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Sword_Position : MonoBehaviour
{
    [SerializeField] XRGrabInteractable grab;
    
    public Transform swordPosition;
    public Vector3 swordSpaceSettings = new Vector3(0f, 0f, 0f);
    
    public bool action = true;
    public bool isSelected = true;

    public GameObject doorTrap;
    public bool isClosed = false;
   
    
    
    private void OnEnable()
    {
        grab.selectEntered.AddListener(StartSelect);
        grab.selectExited.AddListener(StopSelect);
        
    }

    private void OnDisable()
    {
        grab.selectEntered.RemoveListener(StartSelect);
        grab.selectExited.RemoveListener(StopSelect);
    }

    private void Start()
    {
        action = false;
        isSelected = false;
        isClosed = false;

    }

    void Update()
    {
        //SwordPosition(SelectEnterEventArgs args);
        
    }
    
    public void StartSelect(SelectEnterEventArgs args)
    {
        
        action = true;
        
        
        if (action)
        {
            //args.interactableObject.transform.position = args.interactorObject.transform.position + swordSpaceSettings;
            
            isSelected = true;
            
        }
        
    }
    
    public void StopSelect(SelectExitEventArgs args)
    {
        action = false;
        
        if (!action)
        {
            isSelected = false;
            
        }
        
    }
    
}
