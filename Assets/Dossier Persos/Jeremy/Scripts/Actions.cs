using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public GameObject shield;
    public GameObject player;
    public GameObject rightForeArm;
    public bool isShieldEquiped = false;
    
        
        private void OnEnable()
        {
            Event_List.LMB += LeftMouseAction;
            Event_List.RMB += RightMouseAction;
            Event_List.BE += ShieldEquiped;
            //Event_List.USE += UseLever;

        }
            
        private void OnDisable()
        {
            Event_List.LMB -= LeftMouseAction;
            Event_List.RMB -= RightMouseAction;
            Event_List.BE -= ShieldEquiped;
            
        }
        
        private void LeftMouseAction()
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //créer un rayon à partir de la camera principale
                                                                         //jusqu'à la position du curseur dans le 3D world
            
            
            if (Physics.Raycast(ray, out hit))  //verifie si le raycast traverse quelque chose
            {
                Debug.DrawRay(transform.position,Vector3.forward, Color.green, 10);

                if (hit.collider.gameObject.CompareTag("Bouclier"))
                {
                    shield.transform.position = player.transform.position + new Vector3(1,0,0);
                    isShieldEquiped = true;
                    Debug.Log("Shield taken !!!!");
                }
                
            }
            
        }
        
        private void RightMouseAction()
        {
            //Debug.Log("Event RMB");
        }

        public void ShieldEquiped()
        {
            shield.transform.position = rightForeArm.transform.position + new Vector3(0,0,1);
            shield.transform.rotation = rightForeArm.transform.rotation;
            shield.transform.rotation = Quaternion.Euler(0f,180f,0);
            
            isShieldEquiped = true;
            shield.GetComponent<Rigidbody>().useGravity = false;
        }

        /*public void UseLever()
        {
            
        }*/
        

}
