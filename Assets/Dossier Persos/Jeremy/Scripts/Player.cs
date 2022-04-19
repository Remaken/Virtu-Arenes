using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
        public int speedMoves = 0;
        public int speedRotation = 0;

        private void FixedUpdate()
        {
            float translation = Input.GetAxis("Vertical") * speedMoves * Time.deltaTime;
            transform.Translate(0,0, translation);  //défini une direction vers l'avant et l'arrière
            
            float rotation = Input.GetAxis("Horizontal") * speedRotation * Time.deltaTime;
            transform.Rotate(0,rotation, 0);  //défini une rotation via l'axe y et permet de pivoter à G/D
            
        }
        
        
        
        
}
