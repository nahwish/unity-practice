using UnityEngine;

public class bala : MonoBehaviour
{
 public Vector3 direction;
 public float speed = 1;
 public float damage;

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        
    }
}
