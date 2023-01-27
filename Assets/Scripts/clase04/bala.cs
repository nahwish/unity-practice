using UnityEngine;

public class bala : MonoBehaviour
{
 public Vector3 dirBala;
 public float velocidad = 1;
    void Update()
    {
        // transform.Translate(new Vector3(0,0,1f));
        transform.Translate(dirBala * velocidad * Time.deltaTime);
        
    }
}
