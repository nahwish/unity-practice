using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilinder : MonoBehaviour
{
    // Permite que una variable privada pueda ser vista y editada desde la consola de unityt
    [SerializeField]
    // Permite hacer un mouseOver con mensaje a la variable
    [Tooltip("Velocidad de Movimiento del personaje en m/s")]
    // Fijar un rango de movimiento
    [Range(0, 10)]
    private float speed;
    void Update()
    {
        
        
    var buttonW = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
    var buttonA = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
    var buttonS = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
    var buttonD = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
    var speedDelta = speed * Time.deltaTime;

        if (buttonW) Speed(0, 0, speedDelta);//arriba , eje Z
        if (buttonS) Speed(0, 0, -speedDelta);//abajo, eje -Z
        if (buttonA) Speed(-speedDelta, 0, 0);//izquierda, eje -X
        if (buttonD) Speed(speedDelta, 0,0);//derecha, eje X
    }

    //Función para desplazar al objeto, teniendo en cuenta el deltaTime
    // y haciendo que se pueda cambiar el numero desde unity con la variable speed

    //void Speed()
    //{
    //    float space = speed * Time.deltaTime;
    //    transform.Translate(0, 0, space);
    //}
    

    void Speed(float x,float y,float z)
    {
        transform.Translate(x, y, z);
    }
}
