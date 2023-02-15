using UnityEngine;
/// <summary>
/// Detecta cuando un objeto sale del trigger y aplica la escala del componente SizePlayer al objeto que sale.
/// </summary>
public class ParedColision : MonoBehaviour
{
    /// <summary>
    /// Se ejecuta cuando un objeto sale del trigger.
    /// </summary>
    /// <param name="other">El Collider del objeto que sale del trigger.</param>
    private void OnTriggerExit(Collider other) {

        // Obtiene el componente SizePlayer del objeto que sale del trigger
        SizePlayer componente = other.GetComponent<SizePlayer>();
        // Si el componente existe, aplica la escala
        if(componente != null)componente.Scale();

    }
}
