using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField]
    [Tooltip("OBJETO AL CUAL SEGUIR")]
    private GameObject objectToFollow;
    [SerializeField]
    [Tooltip("OBJETO QUE LO SEGUIRÁ")]
    private GameObject objectThatWillFollow;
    [Tooltip("SELECCIONAR LA DISTANCIA A LA CUAL SE DETENDRÁ")]
    [SerializeField]
    private float selectDistance;
    [Tooltip("SELECCIONAR LA VELOCIDAD DE PERSECUSIÓN")]
    [SerializeField]
    private float selectSpeed = 5;
    // public NavMeshAgent agente;

    void Update(){
        MoveTowardsTarget(objectThatWillFollow.transform, objectToFollow.transform, selectDistance,selectSpeed);
   
    }

/// <summary>
/// Mueve una transformación de origen hacia una transformación de destino, hasta una distancia máxima especificada, a una velocidad dada.
/// </summary>
/// <param name="source">La transformación para moverse hacia el objetivo.</param>
/// <param name="target">El objetivo se transforma para moverse hacia.</param>
/// <param name="maxDistance">La distancia máxima desde el origen hasta el destino.</param>
/// <param name="speed">La velocidad a la que mover la fuente hacia el objetivo.</param>
private void MoveTowardsTarget(Transform source, Transform target, float maxDistance, float speed){
    float distance = Vector3.Distance(source.position, target.position);
    if (distance > maxDistance) {
        source.position = Vector3.MoveTowards(source.position, target.position, speed * Time.deltaTime);
    }
}




}


