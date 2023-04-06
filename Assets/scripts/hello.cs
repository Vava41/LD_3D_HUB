using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour
{
   public AudioSource _audio;
   public AudioClip aclip;

   void Start()
   {
        _audio.clip= aclip;
   }
   
   void Update()
   {

   }

   private void OnTriggerEnter(Collider other)
   {
        _audio.Play();
   }
}
