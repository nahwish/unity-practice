using UnityEngine;

public class Look : MonoBehaviour
{
    public Transform target; // El objeto que queremos seguir
    public float speed = 0.1f; // La velocidad de seguimiento

    void Update()
    {
        // Calcular la posición deseada para el objeto que sigue
        Vector3 desiredPosition = target.position;
        // Hacer que el objeto mire hacia el objeto que se está siguiendo
        transform.LookAt(target);
    }
}
// Ejemplo 1 usando quaternion 
// private void LookQuaternion(){
//         Quaternion rot = Quaternion.LookRotation(objeto1.transform.position - objeto2.transform.position);
//         objeto2.transform.rotation = rot;
//    }
//Ejemplo 2 usando LookAt
//  private void LookPlayer(){
//         objeto2.transform.LookAt(objeto1.transform.position);
//    }
