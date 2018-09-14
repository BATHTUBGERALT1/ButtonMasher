using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // data for our class
    public AudioSource clickSound; // sound that will play when we click the button 
    public TextMesh scoreText; // display text for the player score 
    public TextMesh timerText; // display text for the time remaining 
    public float gameLength; // how many seconds will the game last 


    private int score = 0; // this is a numerical data value of our score 
    private float timeRemaining = 0; // numerical time remaining for the game
    private bool gameRunning = true;

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");

        timeRemaining = gameLength; 
	} // End of Start()
	
	// Update is called once per frame
	void Update () {

        Debug.Log("Method Called");

        // update the numerical time remaining 
        timeRemaining = timeRemaining - Time.deltaTime;

        // update the visual time remaining 
        timerText.text = (Mathf.CeilToInt (timeRemaining)).ToString(); 

        if (timeRemaining <= 0)
        {

            gameRunning = false;

            // stop time from going negative
            timeRemaining = 0; 
        } // End of if (timteRunning <=0)
		
	} // End of Update()

    // responds to event from unity that the object has been clicked 
    void OnMouseDown()
    {

        Debug.Log("OnMouseDown Method Called");

        if (gameRunning == true)
        {
            clickSound.Play();
            // increase score by 1 
            score = score + 1;
            // this adds 1 to our total score 
            scoreText.text = score.ToString();
            // update visual score
        } // end of if (game running == true) 
    } // end of mouse down()


} // End of button masher class 
