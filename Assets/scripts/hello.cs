using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour
{
   public AudioSource _audio;
   public AudioClip clip;
   private void OnTriggerEnter(Collider other)
   {
        _audio.PlayOneShot(clip);
   }
}
