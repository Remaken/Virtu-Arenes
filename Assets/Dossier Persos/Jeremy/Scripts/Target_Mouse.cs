using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target_Mouse : MonoBehaviour
{
        private Renderer _renderer;
        public Text pointedObject;
        
        private void Start()
        {
            _renderer = GetComponentInChildren<Renderer>();
        }
        
        
        private void OnMouseEnter()                     //passe la couleur de l'objet en rouge quand curseur souris est dessus
        {
            _renderer.material.color = Color.red;
            pointedObject.text = gameObject.name;
            

        }

        private void OnMouseExit()
        {
            _renderer.material.color = Color.white;     //passe la couleur de l'objet en en blance quand curseur souris n'est plus dessus
        }
        
}
