using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject objeto1;
    public GameObject objeto2;

    void Update(){
        MovePlayer();
    }

   private void MovePlayer(){
        objeto2.transform.position = Vector3.MoveTowards(objeto2.transform.position,objeto1.transform.position,5 * Time.deltaTime);
   }
}


