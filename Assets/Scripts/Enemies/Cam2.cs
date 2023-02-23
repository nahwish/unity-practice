using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam2 : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
      
    void Update()
    {
        var buttonR = Input.GetKeyUp(KeyCode.R);
        if(buttonR){
            
            cam2.SetActive(false);
            cam1.SetActive(true);
        } 
        
    }
}
