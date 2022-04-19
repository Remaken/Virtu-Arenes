using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_List : MonoBehaviour
{
    public Actions _actions;
    private Rigidbody rb;
        
    public delegate void TestRMB(); 
    public static event TestRMB RMB;
        
    public delegate void TestLMB();
    public static event TestLMB LMB;
    
    public delegate void UseEvent();
    public static event UseEvent USE;
    
    public delegate void BouclierEvent();
    public static event BouclierEvent BE;
    
    
    private void Update()
    {
            
        if (Input.GetMouseButtonDown(0))
        {
            LMB?.Invoke();
                
        }
            
        if (Input.GetMouseButtonDown(1))
        {
            RMB?.Invoke();
                
        }

        if (_actions.isShieldEquiped == true)
        {
            BE?.Invoke();

            if (Input.GetKeyDown(KeyCode.T))
            {
                _actions.isShieldEquiped = false;
                _actions.shield.GetComponent<Rigidbody>().useGravity = true;
                Debug.Log("Shield dropped");
            }
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            //USE?.Invoke();
                
        }
            
    }
    
    
}
