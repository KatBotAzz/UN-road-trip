using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
 public class ProgressBarCube : MonoBehaviour 
 {         
    public GameObject progressBar;

     void OnTriggerStay(Collider col)
    {
       progressBar.transform.position =  col.transform.position;
    }

     void OnTriggerEnter(Collider col)
     {
         if (col.gameObject.tag == ("Player"))
         {
            
         }
 
     }
      void OnTriggerExit(Collider col)
     {
         if (col.gameObject.tag == ("Player"))
         {
         }
         
     }
 }
