using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]private Transform moveHere;
    [SerializeField] private GameObject porte;
    public Statue StatueManager;
    [SerializeField] private int porteID;
    private int numeroPorte=0;
    private bool _doorOpened = false;
    private void OnEnable()
    {
        EventManager.DoorOpenEvent += OpenDoor;
    }

    private void Update()
    {
        DoorMovement();
    }

    private void DoorMovement()
    {
        if (_doorOpened == true)
        {
                porte.transform.position = Vector3.MoveTowards(porte.transform.position, moveHere.position,2*Time.deltaTime);
        }
    }

    private void OpenDoor(int triggerID)
    {
        numeroPorte = porteID;
        if (triggerID == porteID && numeroPorte==0)
        {
            _doorOpened = true;
        }

        if(triggerID == porteID && numeroPorte == 1)
        {
            if ((StatueManager.equipements[0].activeSelf==true))
            {
                _doorOpened = true;
            }
        }
        
        if (triggerID == porteID && numeroPorte == 2)
        {
            if ((StatueManager.equipements[1].activeSelf==true))
            {
                _doorOpened = true;
            }
        }

        if (triggerID == porteID && StatueManager.statueCompleted == true && numeroPorte==3)
            _doorOpened = true;
    }

    private void OnDisable()
    {
        EventManager.DoorOpenEvent -= OpenDoor;
    }
}
