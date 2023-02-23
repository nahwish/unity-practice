using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 50.0f;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}

