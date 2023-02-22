using UnityEngine;

/// <summary>
/// Clase que controla el movimiento del objeto en el juego.
/// </summary>
public class MovimientoPlayerStandar : MonoBehaviour
{
    // [SerializeField]
    // [Tooltip("Referencia del script que activa o descativa la animación,'Walk' debe ser un script incorporado en este propio objeto")]
    // private Walk ScriptWalkAnimator;
    // [Tooltip("Componente Animator que tiene el propio objeto")]
    // public Animator anim;
    [Tooltip("Velocidad de movimiento del objeto")]
    public float SpeedMov = 5f;

    /// <summary>
    /// Se actualiza el movimiento del objeto en cada frame.
    /// </summary>
    void Update()
    {
        Movimiento(); 
    }

    /// <summary>
    /// Controla el movimiento del objeto en el juego.
    /// </summary>
    void Movimiento (){
        // Obtiene la entrada del jugador en el eje vertical y Horizontal.
        float vertical = Input.GetAxis("Vertical-P1");
        float horizontal = Input.GetAxis("Horizontal-P1");
        // Velocidad de movimiento estándar.
        Vector3 movimientoJugador = new Vector3(horizontal,0,vertical);
        // Ejecuta un metodo que se encarga de la animación de caminar 
        // ScriptWalkAnimator.SetAnimationWalking(movimientoJugador,anim);
        // if(horizontal != 0 || vertical != 0){
        //     anim.SetFloat("hor",horizontal);
        //     anim.SetFloat("ver",vertical);
        // }
        // Mueve el objeto con el vector de movimiento y la velocidad estándar.
        transform.Translate(movimientoJugador * SpeedMov * Time.deltaTime);
    }

}

