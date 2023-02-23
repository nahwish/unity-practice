using UnityEngine;

public class Follow : MonoBehaviour
{
    [Tooltip("SCRIPT QUE TIENE EL MÉTODO MoveTowardsTarget PARA SEGUIR A UN OBJETO")]
    public LookAndFollow lookandfollowController;
    [Space]
    [Space]
    [SerializeField]
    [Tooltip("OBJETO AL CUAL SEGUIR")]
    public Transform objectToFollow;
    [SerializeField]
    [Tooltip("OBJETO QUE LO SEGUIRÁ")]
    public Transform objectThatWillFollow;
    [Space]
    [Space]
    [Tooltip("SELECCIONAR LA DISTANCIA A LA CUAL SE DETENDRÁ")]
    [SerializeField]
    public float selectDistance;
    [Tooltip("SELECCIONAR LA VELOCIDAD DE PERSECUSIÓN")]
    [SerializeField]
    public float selectSpeed = 5;

    void Update()
    {
        lookandfollowController.MoveTowardsTarget(objectThatWillFollow.transform, objectToFollow.transform, selectDistance,selectSpeed);
        lookandfollowController.LookPlayer(objectToFollow,objectThatWillFollow);
    }
}


