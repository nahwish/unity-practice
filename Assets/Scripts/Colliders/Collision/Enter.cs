using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    
   
    //la primera vez que choca
    private void OnCollisionEnter(Collision collision) {
        SizeCube componente = GetComponent<SizeCube>();
        if(componente != null){
            componente.Scale();
        }
    }
   
  
    //mientras esté chocando
    // private void OnCollisionStay(Collision other) {}
    
    // se ejecutan cuando está tildado "is trigger" en un objeto de forma similar a los anteriores
    // private void OnTriggerEnter(Collision other) {}
    // private void OnTriggerStay(Collider other) {Debug.Log("trigger stay");}
    // private void OnTriggerExit(Collision other) {}


}

