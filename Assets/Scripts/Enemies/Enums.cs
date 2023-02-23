using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Enemies{
    Enemy1,Enemy2
}



public class Enums : MonoBehaviour
{
    
    public Enemies enemies;

    void Update()
    {
        switch (enemies)
        {
            case Enemies.Enemy1:
                Debug.Log("Enemigo uno");
            break;
            case Enemies.Enemy2:
                Debug.Log("Enemigo dos");
            break;
            default:
            Debug.Log("nada");
            break;
        }
        
    }
}
