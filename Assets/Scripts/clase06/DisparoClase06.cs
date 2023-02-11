
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoClase06 : MonoBehaviour
{
    [SerializeField]
    private GameObject bala;
    [SerializeField]
    private Transform balaPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawn();
    }





    void spawn(){
        var button = Input.GetKey(KeyCode.E);
        if(button) Instantiate(bala, balaPosition.position, transform.rotation );
    }
}
