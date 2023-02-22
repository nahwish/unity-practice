using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    
/// <summary>
/// Establece la animación de caminar del personaje en función de su movimiento.
/// </summary>
/// <param name="movimientoJugador">El movimiento actual del personaje en un Vector3.</param>
/// <param name="anim">El Animator del personaje.</param>
public void SetAnimationWalking(Vector3 movimientoJugador, Animator anim){
    if(movimientoJugador == Vector3.zero){
        anim.SetBool("caminando", false);
    }else{
        anim.SetBool("caminando", true);
        // transform.rotation = Quaternion.LookRotation(movimientoJugador);
    }
}

}
