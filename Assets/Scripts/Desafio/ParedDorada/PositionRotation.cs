using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRotation : MonoBehaviour
{
    public float timer = 0.0f;
    public float waitTime = 2.0f;
    
    private void OnTriggerStay(Collider other) {
        timer += Time.deltaTime;
    if (timer > waitTime)
    {
        this.transform.Translate(5f,5f,5f);
        this.transform.Rotate(8,5,12);
    }
        
        }
}
