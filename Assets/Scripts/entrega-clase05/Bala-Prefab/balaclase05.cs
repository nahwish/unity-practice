using UnityEngine;

public class balaclase05 : MonoBehaviour
{
 public Vector3 direction;
 public float speed = 1;
 public float damage;
public float scale = 2;
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        Scale();
    }
    void Scale(){

        if( Input.GetKey(KeyCode.V)){
            transform.localScale *= 0.5f;
        }
    }
}