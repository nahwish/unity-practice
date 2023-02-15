using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeCube : MonoBehaviour
{
    
    public void Scale(){
    // Obtener la escala actual del objeto
    Vector3 escalaActual = transform.localScale;
    // Definir una nueva escala aumentando en un 50%
    Vector3 nuevaEscala = new Vector3(escalaActual.x * 5f, escalaActual.y * 5f, escalaActual.z * 5f);
    // Asignar la nueva escala al objeto
    transform.localScale = nuevaEscala;

    }

}
