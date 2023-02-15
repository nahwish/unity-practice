using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
   
    public AudioSource gorillazAudio;

    void start()
    {
         var buttonT = Input.GetKeyUp(KeyCode.T);
         if(buttonT){
          AudioSource[] allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
            foreach(AudioSource audioS in allAudioSources)
            {
                gorillazAudio.Stop();
            }
    }
    }
}
