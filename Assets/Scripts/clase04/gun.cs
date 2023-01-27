using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    // public GameObject arma;
    public GameObject bala;
    public Transform balaPosition;
    void Start()
    {
        // Instantiate(arma);
        Instantiate(bala, balaPosition.position, transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
