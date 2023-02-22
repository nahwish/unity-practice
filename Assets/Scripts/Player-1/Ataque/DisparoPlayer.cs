using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controla el disparo de un objeto utilizando un temporizador.
/// </summary>
public class DisparoPlayer : MonoBehaviour
{
    /// <summary>
    /// Prefab de la bala a instanciar.
    /// </summary>
    [SerializeField]
    [Tooltip("Prefab a instanciar")]
    private GameObject bala;
    [Tooltip("Componente Animator que tiene el propio objeto")]
    public Animator anim;
    /// <summary>
    /// Transform donde se creará la bala.
    /// </summary>
    [SerializeField]
    [Tooltip("Hace referencia al objeto vacio creado dentro del tanque")]
    private Transform balaPosition;


    void Update()
    {
        spawn();
    }

    void spawn(){
            var buttonE = Input.GetKeyDown(KeyCode.E);
            if(buttonE){
            Instantiate(bala, balaPosition.position, transform.rotation );
            
            // anim.SetBool("ataque", false);
              
            // }else{
            //     anim.SetBool("ataque", true);
            }   
        }
    // public void SetAnimationWalking(Vector3 movimientoJugador, Animator anim){
    //     if(movimientoJugador == Vector3.zero){
    //         anim.SetBool("caminando", false);
    //     }else{
    //         anim.SetBool("caminando", true);
    //     }
    // }
    

}
