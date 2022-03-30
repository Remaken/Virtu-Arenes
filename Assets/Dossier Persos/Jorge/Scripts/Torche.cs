using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torche : MonoBehaviour
{
    public delegate void TorchEvent();

    public static event TorchEvent TorchHolding;
   [SerializeField] private GameObject Torch;
    private bool _playerContact=false;
    

    private void Update()
    {
        GiveTorch();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _playerContact = true;
        }
    }

    public GameObject GiveTorch()
    {
        if (_playerContact==true)
        {
            TorchHolding?.Invoke();
        }
        return Torch;
    }
}
