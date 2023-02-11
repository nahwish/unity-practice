using UnityEngine;

/// <summary>
/// Clase que controla el aumento de tamaño de un objeto al presionar la tecla 'v'.
/// </summary>
public class MutationScale : MonoBehaviour
{
    /// <summary>
    /// El factor de escala a aplicar al objeto cuando se presione la tecla 'v'.
    /// </summary>
    [SerializeField]
    private float scale = 2;
    void Update()
    {
        Scale();
    }
    /// <summary>
    /// Aumenta el tamaño del objeto cuando se presiona la tecla 'v'.
    /// </summary>
    void Scale()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.localScale *= scale;
        }
    }
}
