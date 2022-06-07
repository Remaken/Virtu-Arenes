using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_TriggerExit_Zone : MonoBehaviour
{

    public Door_mecanism _DmMecanism;
    private Object_Interaction _ObjectInteraction;
    
    
    private void OnTriggerStay(Collider other)      // Sortir de la zone de trigger entourant le piedestal - avec l'épée _ fera apparaitre un mur

    {
        Debug.Log("Walking on " + other.name);
        Debug.Log("Walking on " + other.tag);
        /*if (_ObjectInteraction.isSelected)
        {
            Debug.Log("Walking on SpawnGround");
        }*/
        
       /* if (other.gameObject.CompareTag("SpawnGround") && _ObjectInteraction.isSelected)    
        {
            _DmMecanism.doorTrap.SetActive(true);
        }*/
    }
}
