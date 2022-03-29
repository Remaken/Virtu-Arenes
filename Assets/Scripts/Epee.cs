using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Epee : MonoBehaviour
{ private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
