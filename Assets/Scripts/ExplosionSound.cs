using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
 public class ExplosionSound : MonoBehaviour 
 {
    AudioSource m_MyAudioSource;
         
     void Start()
     {
         m_MyAudioSource = GetComponent<AudioSource>();
     }
 
     void OnTriggerEnter(Collider col)
     {
         if (col.gameObject.tag == ("Player"))
         {
             m_MyAudioSource.Play();
         }
 
     }
      void OnTriggerExit(Collider col)
     {
         if (col.gameObject.tag == ("Player"))
         {
             m_MyAudioSource.Stop();
         }
         
     }
 }
