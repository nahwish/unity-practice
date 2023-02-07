using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyClase05 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float time;

    void Start()
    {
        Destroy(gameObject,10f);
    }

    // Update is called once per frame
   
     
}
