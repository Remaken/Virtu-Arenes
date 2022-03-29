using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Visiteur : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    private void FixedUpdate()
    {
        PlayerMouvement();
    }

    private void PlayerMouvement()
    {
        
        this.transform.Translate(0f,0f,Input.GetAxis("Vertical")*_moveSpeed * Time.fixedDeltaTime);
        this.transform.Rotate(new Vector3(0f, Input.GetAxis("Horizontal")*_moveSpeed*10f*Time.fixedDeltaTime, 0f));
    }
}
