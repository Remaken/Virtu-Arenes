using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casque : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
