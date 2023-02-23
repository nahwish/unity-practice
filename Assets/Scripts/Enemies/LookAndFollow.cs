using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAndFollow : MonoBehaviour
{
/// <summary>
/// Hace que el objeto especificado (lookingObject) mire hacia la posición del objeto especificado para mirar (objectToLookAt).
/// </summary>
/// <param name="objectToLookAt">El Transform que representa el objeto para mirar.</param>
/// <param name="lookingObject">El Transform que representa el objeto que mirará al otro objeto.</param>
    public void LookPlayer(Transform objectToLookAt, Transform lookingObject) {
        lookingObject.transform.LookAt(objectToLookAt.transform.position);
    }

/// <summary>
/// Mueve el objeto de origen (source) hacia el objeto de destino (target) con una velocidad determinada si la distancia entre ellos es mayor que la distancia máxima permitida.
/// </summary>
/// <param name="source">El Transform del objeto de origen que se va a mover.</param>
/// <param name="target">El Transform del objeto de destino hacia el que se va a mover.</param>
/// <param name="maxDistance">La distancia máxima permitida entre el objeto de origen y el objeto de destino.</param>
/// <param name="speed">La velocidad a la que se va a mover el objeto de origen hacia el objeto de destino.</param>
     public void MoveTowardsTarget(Transform source, Transform target, float maxDistance, float speed)
     {
        float distance = Vector3.Distance(source.position, target.position);
        if (distance > maxDistance) 
        {
            source.position = Vector3.MoveTowards(source.position, target.position, speed * Time.deltaTime);
        }
    }

}
