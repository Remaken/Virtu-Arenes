using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;
public enum PlayerState
{
    None,
    Walking,
    HasSword,
    HasBreastPlate,
    HasShield,
    HasHelmet,
}
public class Visiteur : MonoBehaviour
{ 
    public PlayerState state = PlayerState.None;
    public PlayerState nextState = PlayerState.None;
    
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private GameObject _rightHand;
    [SerializeField] private GameObject _leftHand;
    private bool _holdingTorch = false;

    private void OnEnable()
    {
        Torche.TorchHolding += HoldTorch;
    }

    private void Start()
    {
        state = PlayerState.Walking;
    }
    
   private void Update()
    {
        if (CheckForTransition())
        {
            TransitionOrChangeState();
        }
        StateBehaviour();
    }
    private void FixedUpdate()
    {
        PlayerMouvement();
    }


    private bool CheckForTransition()
    {
        switch (state)
        {
            case PlayerState.None:
                break;
            case PlayerState.Walking:
                break;
            case PlayerState.HasHelmet:
                break;
            case PlayerState.HasShield:
                break;
            case PlayerState.HasSword:
                break;
            case PlayerState.HasBreastPlate:
                break;
        }
        return false;
    }

    private void TransitionOrChangeState()
    {
        switch (nextState)
        {
            case PlayerState.None:
                break; 
            case PlayerState.Walking:
                break;
            case PlayerState.HasHelmet:
                break;
            case PlayerState.HasShield:
                break;
            case PlayerState.HasSword:
                break;
            case PlayerState.HasBreastPlate:
                break;
        }

        state = nextState;
    }

    private void StateBehaviour()
    {
        switch (state)
        {
            case PlayerState.None:
                break; 
            case PlayerState.Walking:
                break;
            case PlayerState.HasHelmet:
                break;
            case PlayerState.HasShield:
                break;
            case PlayerState.HasSword:
                break;
            case PlayerState.HasBreastPlate:
                break;
        }
    }

    private void PlayerMouvement()
    {
        
        this.transform.Translate(0f,0f,Input.GetAxis("Vertical")*_moveSpeed * Time.fixedDeltaTime);
        this.transform.Rotate(new Vector3(0f, Input.GetAxis("Horizontal")*_moveSpeed*10f*Time.fixedDeltaTime, 0f));
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Torch"))
        {
            _holdingTorch = true;
        }
    }

    private void HoldTorch()
    {
        if (_holdingTorch==true)
        {
           Torche.torch
        }

        if (Input.GetKey(KeyCode.G))
        {
            _holdingTorch = false;
        }
    }
    
    private void OnDisable()
    {
        Torche.TorchHolding -= HoldTorch;
    }
}
