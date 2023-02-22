using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Comportamiento {
    Objeto1,
    Objeto2
}
public class SwitchControl : MonoBehaviour
{
    public Comportamiento comportamientoObjeto;


    void Update() {
        switch (comportamientoObjeto) {
            case Comportamiento.Objeto1:
                Objeto1();
                break;
            case Comportamiento.Objeto2:
                Objeto2();
                break;
            default:
                break;
        }
    }
    void Objeto1() {
        Vector3 escalaActual = this.transform.localScale;
        
        // Aumentamos la escala en cada eje multiplicándolo por el factor deseado
        escalaActual.y += 0.001f;
        // Actualizamos la escala del objeto
        this.transform.localScale = escalaActual;
        Debug.Log("Soy el objeto 1");
    }
    
    void Objeto2() {
         Vector3 escalaActual = this.transform.localScale;
        
        // Aumentamos la escala en cada eje multiplicándolo por el factor deseado
        escalaActual.x = 1f;
        escalaActual.y = 2f;
        escalaActual.z = 1f;
        this.transform.localScale = escalaActual;
        Debug.Log("Soy el objeto 2");
    }
}
