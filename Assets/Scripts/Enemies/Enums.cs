using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Enemies{
    Follow,Look
}

public class Enums : MonoBehaviour
{
   
    [SerializeField]
    private Enemies optionSelected;
    [Tooltip("SCRIPT QUE TIENE EL MÉTODO MoveTowardsTarget PARA SEGUIR Y LookPlayer PARA MIRAR A UNA OBJETO")]
    public LookAndFollow LookAndFollowController;
    [Space]
    [Space]
    [SerializeField]
    [Tooltip("OBJETO AL CUAL SEGUIR")]
    private Transform objectToFollow;
    [SerializeField]
    [Tooltip("OBJETO QUE LO SEGUIRÁ")]
    private Transform objectThatWillFollow;
    [Space]
    [Space]
    [Tooltip("SELECCIONAR LA DISTANCIA A LA CUAL SE DETENDRÁ")]
    [SerializeField]
    private float selectDistance;
    [Tooltip("SELECCIONAR LA VELOCIDAD DE PERSECUSIÓN")]
    [SerializeField]
    private float selectSpeed = 5;

   
    void Update()
    {
        switch (optionSelected)
        {
            case Enemies.Follow:
                 LookAndFollowController.MoveTowardsTarget(objectThatWillFollow.transform, objectToFollow.transform, selectDistance,selectSpeed);
                 LookAndFollowController.LookPlayer(objectToFollow,objectThatWillFollow);               
            break;
            case Enemies.Look:
                 LookAndFollowController.LookPlayer(objectToFollow,objectThatWillFollow);                
            break;
            default:
            Debug.Log("nada");
            break;
        }
    }
}
