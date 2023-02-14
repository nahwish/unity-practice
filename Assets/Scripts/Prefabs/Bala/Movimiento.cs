using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Clase que se ocupa de desplazarse hacia algún eje, editable 
/// </summary>
public class Movimiento : MonoBehaviour
{
     /// <summary>
    /// La dirección en la que se moverá el objeto.
    /// </summary>
    [SerializeField]
    [Tooltip("Utiliza el eje  Z en 1 para avanzar hacia a delante")]
    private Vector3 direction;
    /// <summary>
    /// La velocidad a la que se moverá el objeto.
    /// </summary>
    [SerializeField]
    private float speed = 1;
    /// <summary>
    /// El daño que causará el objeto cuando colisione con otro objeto.
    /// </summary>
    [SerializeField]
    private float damage;

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
