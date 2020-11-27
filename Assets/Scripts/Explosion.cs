using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
      void OnTriggerEnter (Collider coll) {
          if (coll.gameObject.tag == ("Player")) 
          {
              Explode ();
          }
      }
      void Explode () {
          transform.parent.GetComponent<ParticleSystem>().Play();

          var systems = transform.parent.GetComponentsInChildren<ParticleSystem>();
          foreach (var system in systems){
              system.Play();
          }
      }
}