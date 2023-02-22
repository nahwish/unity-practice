using UnityEngine.AI;
using UnityEngine;

public class FollowWithIA : MonoBehaviour
{
    [SerializeField]
    [Tooltip("OBJETIVO AL CUAL PERSEGUIR, SE OBTIENE SU POSICIÓN")]
    public Transform objetivo;
    [Tooltip("Hace referencia al agente de este mismo objeto, agregando el componente NavMeshAgent")]
    private NavMeshAgent agente;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agente.SetDestination(objetivo.position);
        transform.LookAt(objetivo);
    }
}

  

