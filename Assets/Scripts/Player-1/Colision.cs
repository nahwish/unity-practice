using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //la primera vez que choca
    private void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == "Pared"){
            Debug.Log("funciona");
        };
    }
    //cuando el objeto deja de chocar
    private void OnCollisionExit(Collision other) {
        if(other.gameObject.name == "Pared"){
            Debug.Log("ya no--------->");
        };
    }
    //mientras esté chocando
    // private void OnCollisionStay(Collision other) {}
    
    // se ejecutan cuando está tildado "is trigger" en un objeto de forma similar a los anteriores
    // private void OnTriggerEnter(Collision other) {}
    // private void OnTriggerStay(Collider other) {Debug.Log("trigger stay");}
    // private void OnTriggerExit(Collision other) {}
}

