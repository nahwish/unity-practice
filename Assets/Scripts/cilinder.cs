using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilinder : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Velocidad de Movimiento del personaje en m/s")]
    [Range(0, 10)]
    private float speed;
    [SerializeField]
    [Tooltip("Vida de 0 100")]
    [Range(0, 100)]
    private float life;
    [SerializeField]



   
    void Update()
    {
        Mov();
        if(life <= 50)Cure();
        else Damage();
    }
    void Cure(){
        life += 0.004f;
    }
    void Damage(){
        life -= 0.002f;
    }
    void Mov(){
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
    void Speed(float x,float y,float z){
        transform.Translate(x, y, z);
    }
   
}
