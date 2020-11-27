using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBarCubeNew : MonoBehaviour
{

    //public GameObject progressBar;

void OnTriggerEnter(Collider collider) 
	{
		print($"TurnBack.OnTriggerEnter: {collider.name}");
       // GetComponent<ProgressBar>().progressBar = true;
        // GetComponent<ProgressBar>().progressBar;    

		if (collider.gameObject.tag == ("Player"))
        {
        	//GuiOn = true; 
		}
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
