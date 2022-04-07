using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public GameObject shield;
    public GameObject player;
        private void OnEnable()
        {
            Player.LMB += LeftMouseAction;
            Player.RMB += RightMouseAction;
            
        }
            
        private void OnDisable()
        {
            Player.LMB -= LeftMouseAction;
            Player.RMB -= RightMouseAction;
            
        }
        
        private void LeftMouseAction()
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //créer un rayon à partir de la camera principale jusqu'à la position du curseur dans le 3D world
            
            
            if (Physics.Raycast(ray, out hit))  //verifie si le raycast traverse quelque chose
            {
                Debug.Log("Event LMB");
                Debug.DrawRay(transform.position,Vector3.forward, Color.green, 10);

                if (hit.collider.gameObject.CompareTag("Bouclier"))
                {
                    shield.transform.position = player.transform.position + new Vector3(1,0,0);
                    Debug.Log("Bouclier acquis !!!!");
                }
                
            }
            
        }
        
        private void RightMouseAction()
        {
            Debug.Log("Event RMB");
        }

        private void ShieldEquiped()
        {
            //shield.transform.position = player.transform.position + new Vector3(1,0,0);
        }

}
