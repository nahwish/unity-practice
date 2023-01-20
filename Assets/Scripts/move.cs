
using UnityEngine;

 public class move : MonoBehaviour
{
    //- VARIABLES
    int num = 5;
    float velocidad = 10.5f;
    char caracter = '*';
    string cadenaDeCaracter = "Esta es mi";
    bool muerto = true;
    //- TRANSLACIÓN
    public Vector3 mov;
    // Start is called before the first frame update
    //se llama una sola vez al principio del juego
    void Start()
    {
        //Debug.Log(num);
        //Debug.Log($"<color=green><size=30>{num}</size></color>");

    }

    // Update is called once per frame
    //Se llama una vez por cada frame
    //fps: fotogramas por segundo
    //por ejemplo 60fps, singnifica que se va a llamra esta funcion 60 veces por segundo
    //se pueden realizar diferentes interacciones
    void Update()
    {
        //- TRANSLACIÓN
        // Vector3(x,y,z)
        //transform.position += new Vector3(0.1f,0,0);
        //transform.Translate(mov) otra forma de acceder a las coordenadas
       // Debug.Log($"<color=green><size=30>{num}</size></color>");

       //- ROTACIÓN
       //transform.Rotate(1,0,0);
    transform.localScale += new Vector3(1,1,1);
    }
}
