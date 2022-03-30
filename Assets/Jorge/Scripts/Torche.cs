using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torche : MonoBehaviour
{
    public delegate void TorchEvent();

    public static event TorchEvent TorchHolding;
    public GameObject Torch;
    private bool _playerContact=false;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _playerContact = true;
        }
        else
        {
            _playerContact = false;
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
