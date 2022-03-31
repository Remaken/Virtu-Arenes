using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public GameObject sphereTest;
    public Transform playerTransform;
    
    private void OnEnable()
    {
        Player.Up += RightMouseAction;
        Player.Click += LeftMouseAction;

    }
        
    private void OnDisable()
    {
        Player.Up -= RightMouseAction;
        Player.Click -= LeftMouseAction;
            
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
            Debug.DrawRay(transform.position,Vector3.forward, Color.green, 10);
            Vector3 direction = new Vector3(hit.point.x, playerTransform.position.y, hit.point.z);
            playerTransform.LookAt(direction);
            Debug.Log("Test LeftMouseAction");
            
            
        }
        
    }

    
}
