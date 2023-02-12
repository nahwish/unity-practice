using UnityEngine;

public class MovCam : MonoBehaviour
{
    public float tiempoRestante;
    public float tiempoOriginal;
   
    void Update()
    {
       
        Movimiento();
      
    }
    
        void Movimiento (){
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            float movimientoStandar = 15f;

            Vector3 movimientoJugador = new Vector3(horizontal,0,vertical);
            transform.Translate(movimientoJugador * movimientoStandar * Time.deltaTime);
        }
        
}
