using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public GameObject sphereTest;   
    
    
    private void OnEnable()
    {
        Player.Up += RightMouseAction;
            
    }
        
    private void OnDisable()
    {
        Player.Up -= RightMouseAction;
            
    }
    
    
    private void RightMouseAction()
    {
        gameObject.SetActive(false);
    }

    private void LeftMouseAction()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Test");
        }
        
    }
    
}
