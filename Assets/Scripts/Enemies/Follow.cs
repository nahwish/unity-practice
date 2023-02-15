using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Objeto a cual seguir")]
    private GameObject objeto1;
    [SerializeField]
    [Tooltip("Objeto que lo seguirá")]
    private GameObject objeto2;

    void Update(){
        MovePlayer();
    }

   private void MovePlayer(){
        objeto2.transform.position = Vector3.MoveTowards(objeto2.transform.position,objeto1.transform.position,5 * Time.deltaTime);
   }
}


