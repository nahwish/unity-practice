using UnityEngine;

public class SizePlayer : MonoBehaviour
{
   public GameObject player;
   bool onTriggerIsActive = false;

   public void Scale(){
    Vector3 nuevaEscala = new Vector3(0.5f,2.5f,0.5f);
    Vector3 originalEscala = new Vector3(1f,3f,1f);
  
    if(onTriggerIsActive){
        player.transform.localScale = originalEscala;
        onTriggerIsActive = false;
    }else{
        player.transform.localScale = nuevaEscala;
        onTriggerIsActive = true;
    }

    }

}
