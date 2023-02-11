using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controla el disparo de un objeto utilizando un temporizador.
/// </summary>
public class DisparoClase05 : MonoBehaviour
{
    /// <summary>
    /// Prefab de la bala a instanciar.
    /// </summary>
    [SerializeField]
    [Tooltip("Prefab a instanciar")]
    private GameObject bala;

    /// <summary>
    /// Transform donde se creará la bala.
    /// </summary>
    [SerializeField]
    [Tooltip("Hace referencia al objeto vacio creado dentro del tanque")]
    private Transform balaPosition;

    /// <summary>
    /// Tiempo original que el temporizador usará para contar.
    /// </summary>
    [SerializeField]
    [Tooltip("Desde dónde parte el contador")]
    private float tiempoOriginal;

    /// <summary>
    /// Tiempo restante en el temporizador.
    /// </summary>
    [SerializeField]
    [Tooltip("Editable, muestra la cuenta regresiva")]
    private float tiempoRestante;

    void Update()
    {
        Temporizador();
    }

    /// <summary>
    /// Temporiza el disparo de la bala.
    /// </summary>
    void Temporizador()
    {
        tiempoRestante -= Time.deltaTime;
        if (tiempoRestante <= 0)
        {
            /// <sumamery>
            /// recibe el gameObject,  la posicion y rotación del objeto vacio            /// </summary>
            Instantiate(bala, balaPosition.position, transform.rotation);
            /// <summary>
            /// Reinicia el temporizador.
            /// </summary>
            tiempoRestante = tiempoOriginal;
        }
    }

}
