using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanque : MonoBehaviour
{
    public GameObject bala;
    public Transform balaPosition;
    void Start()
    {
        

    }
    void Update() {
        Disparo();
        
    }
    void Disparo() {
        var button = Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.L);

        if(button){
        Instantiate(bala, balaPosition.position, transform.rotation );

        }
    }
    
    
}
