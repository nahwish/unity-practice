using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam1 : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
  
    void Update()
    {
        var buttonT = Input.GetKeyUp(KeyCode.T);
        if(buttonT){
            cam2.SetActive(true);
            cam1.SetActive(false);
        } 
        
    }
}
