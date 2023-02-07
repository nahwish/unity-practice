using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///Clase principal de la aplicación.
///</summary>
///<remarks>
///Lee archivos de configuración y crea los hilos que ejecutan el resto del programa.
///</remarks>
public class DisparoClase05 : MonoBehaviour
{

    [SerializeField]
    private GameObject bala;
    [SerializeField]
    private Transform balaPosition;
    [SerializeField]
    private float tiempoOriginal;
    [SerializeField]
    private float tiempoRestante;

    void Start()
    {
        

    }
    void Update() {
        Temporizador();
    }
   
        // var button = Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.L);

        void Temporizador (){
            tiempoRestante -= Time.deltaTime;
            if(tiempoRestante <= 0 ){
            Instantiate(bala, balaPosition.position, transform.rotation );
            ResetTemporizador();
            }
        }
        void ResetTemporizador(){
            tiempoRestante = tiempoOriginal;
        }
}