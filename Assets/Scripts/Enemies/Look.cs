using UnityEngine;

public class Look : MonoBehaviour
{
    [SerializeField]
    [Tooltip("OBJETO AL CUAL SEGUIR CON LA MIRADA")]
    private Transform objectToFollowWithTheEye; 
    [SerializeField]
    [Tooltip("ESTABLECER UNA VELOCIDAD DE GIRO PARA LA VELOCIDAD DEL MOVIMIENTO")]
    private float speedLook = 10f;

    void Update()
    {
        objectToFollow();
    }


    void objectToFollow(){
        // Calcula la dirección en la que debe mirar el objeto actual
        Vector3 direction = objectToFollowWithTheEye.position - transform.position;
        // Crea una rotación quaternion a partir de la dirección
        Quaternion objectToFollowWithTheEyeRotation = Quaternion.LookRotation(direction);
        // Interpola suavemente la rotación actual del objeto hacia la rotación que mira al objeto que sigue
        transform.rotation = Quaternion.Slerp(transform.rotation, objectToFollowWithTheEyeRotation, speedLook * Time.deltaTime);

    }
}

