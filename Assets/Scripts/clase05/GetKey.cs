using UnityEngine;

public class GetKey : MonoBehaviour
{
    public float tiempoRestante;
    public float tiempoOriginal;
    void Start()
    {
        
    }

   
    void Update()
    {
        // if(Input.GetKey(KeyCode.W)){
        //     transform.Translate(new Vector3(0,0,0.1f));
        // }
        // if(Input.GetKey(KeyCode.S)){
        //     transform.Translate(new Vector3(0,0,-0.1f));
        // }
        // if(Input.GetKey(KeyCode.A)){
        //     transform.Translate(new Vector3(0.1f,0,0));
        // }
        // if(Input.GetKey(KeyCode.D)){
        //     transform.Translate(new Vector3(-0.1f,0,0));
        // }
        Movimiento();
        Temporizador();
    }
    
        void Movimiento (){
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            float movimientoStandar = 15f;

            Vector3 movimientoJugador = new Vector3(horizontal,0,vertical);
            transform.Translate(movimientoJugador * movimientoStandar * Time.deltaTime);
        }
        void Temporizador(){
            tiempoRestante -= Time.deltaTime;
            if(tiempoRestante <= 0){
                ResetTemporizador();
                Debug.Log("LISTO");
            }
        }
        void ResetTemporizador(){
            tiempoRestante = tiempoOriginal;
        }
}
