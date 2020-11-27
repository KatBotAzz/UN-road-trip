using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ProgressBarTest: MonoBehaviour

{
    public ProgressBarPro barTest;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //print(transform.position.y/10);
      barTest.SetValue(transform.position.y/10);  
    }
}
