using UnityEngine;

public class Look : MonoBehaviour
{
    [Tooltip("Script que tiene el método 'LookPlayer' para seguirlo con la vista")]
    [SerializeField]
    private LookAndFollow standardLookAt;
    [Space]
    [Space]
    [Tooltip("Objeto al cual queremos seguir con la mirada")]
    [SerializeField]
    private Transform objectToLookAt; 
    [Tooltip("Objeto que lo va a seguir con la vista")]
    [SerializeField]
    private Transform lookingObject; 


    void Update()
    {
        standardLookAt.LookPlayer(objectToLookAt,lookingObject);
    }
}

 
