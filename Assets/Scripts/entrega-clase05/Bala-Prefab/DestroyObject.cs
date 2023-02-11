using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Tiempo maximo que espera el objeto para destruirse")]
    private float time;

    void Start()
    {
        Destroy(gameObject,time);
    } 
}
