using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // data for our class
    public AudioSource clickSound; // sound that will play when we click the button 
    public TextMesh scoreText; // display text for the player score 

    private int score = 0; // this is a numerical data value of our score 

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
        // increase score by 1 
        score = score + 1;
        // this adds 1 to our total score 
        scoreText.text = score.ToString();
        // update visual score

    } // end of mouse down()


} // End of button masher class 
