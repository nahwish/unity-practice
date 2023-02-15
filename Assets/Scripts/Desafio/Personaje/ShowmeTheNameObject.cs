using UnityEngine;

/// <summary>
/// Imprime en la consola el nombre del objeto con el que colisiona y verifica si tiene un componente ParedColision.
/// </summary>
public class ShowmeTheNameObject : MonoBehaviour
{
    /// <summary>
    /// Se ejecuta cuando el objeto entra en el trigger de otro objeto.
    /// </summary>
    /// <param name="other">El Collider del objeto con el que colisiona.</param>
    private void OnTriggerEnter(Collider other) {

        // Imprime el nombre del objeto con el que colisiona
        Debug.Log(other.name);

        // Obtiene el componente ParedColision del objeto con el que colisiona
        ParedColision component = other.GetComponent<ParedColision>();

        // Si el componente existe, imprime un mensaje en la consola
        if(component != null)
        {
            Debug.Log("ParedColision en mi shrinker del portal, encontrado!");
        } 
    }
}
