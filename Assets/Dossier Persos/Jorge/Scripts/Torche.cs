using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torche : MonoBehaviour
{
    public delegate void TorchEvent();

    public static event TorchEvent TorchHolding;
    private bool _playerContact=false;
    [SerializeField] private Visiteur PlayerManager;



    private void Update()
    {
        GiveTorch();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && _playerContact == false)
        {
            _playerContact = true;
        }
    }

    private void GiveTorch()
    {
        if (_playerContact == true)
        {
            _playerContact = false;
            TorchHolding?.Invoke();
            
            Visiteur.TorchDrop += TorchReset;
            gameObject.transform.position=PlayerManager.leftHand.transform.position;
            gameObject.transform.parent = PlayerManager.leftHand.transform;
        }
    }

    private void TorchReset()
    {
        Destroy(this.gameObject);
    }
    private void OnDisable()
    {
        Visiteur.TorchDrop -= TorchReset;
    }
}
