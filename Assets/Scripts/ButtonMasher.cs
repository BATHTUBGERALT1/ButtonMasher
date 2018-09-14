using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    public AudioSource clickSound; // sound that will play when we click the button 

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");
	} // End of Start()
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Method Called");
		
	} // End of Update()

    // responds to event from unity that the object has been clicked 
    void OnMouseDown()
    {

        Debug.Log("OnMouseDown Method Called");
        clickSound.Play(); 

    } // end of mouse down()


} // End of button masher class 
