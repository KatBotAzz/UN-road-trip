using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrainScript : MonoBehaviour
{
    public int GameoverCounter = 3;
    public GameObject Jeep;
    public Vector3 JeepPosition;
    public Quaternion JeepRotation;
    public string GameoverSceneName;
    //int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

    void Start ()
    {
        JeepPosition = Jeep.transform.position;
        
        JeepRotation = Jeep.transform.rotation;
    }

   void OnCollisionEnter (Collision col) {
        GameoverCounter--;
        if (GameoverCounter == 0) { 
           SceneManager.LoadScene(GameoverSceneName);
         }
       
       Jeep.transform.rotation = JeepRotation;

       Jeep.transform.position = JeepPosition;
       Jeep.GetComponent<Rigidbody>().isKinematic = true;
       Jeep.GetComponent<Rigidbody>().isKinematic = false;
          
   }

   void ResetOrientation () {
     //Jeep.transform.rotation.SetLookRotation(Jeep.transform.forward, Vector3.up);
     Jeep.transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
      // Jeep.transform.localRotation = Quaternion.Euler(Jeep.transform.localRotation.x, Jeep.transform.localRotation.y, 0); 
   } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
          ResetOrientation();
            //print("space key was pressed");
        }
      
    }
}
