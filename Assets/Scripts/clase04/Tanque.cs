using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanque : MonoBehaviour
{
    public GameObject bala;
    public Transform balaPosition;
    void Start()
    {
        
        Disparo();

    }

    void Disparo() => Instantiate(bala, balaPosition.position, transform.rotation);
}
