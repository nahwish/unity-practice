using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject bala;
    public Transform balaPosition;
    void Start()
    {
        
        Disparo();

    }

    void Disparo() => Instantiate(bala, balaPosition.position, transform.rotation);
}
