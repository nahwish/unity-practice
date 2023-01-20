
using UnityEngine;

 public class move : MonoBehaviour
{
    //- TRANSLACIÓN
     void Start()
    {

    }

    void Update()
    {
        //- TRANSLACIÓN
       transform.position += new Vector3(0.001f,0,0);
       //- ROTACIón
        transform.localScale += new Vector3(0.1f,0.1f,0.1f);
    }
}
