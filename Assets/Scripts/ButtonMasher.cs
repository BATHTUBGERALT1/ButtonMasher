using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // data for our class
    public AudioSource clickSound; // sound that will play when we click the button 
    public TextMesh scoreText; // display text for the player score 
    public TextMesh timerText; // display text for the time remaining 
    public float gameLength; // how many seconds will the game last 
    public AudioSource gameOverSound; // sound that will play when we run out of time
    public TextMesh messageText; // display text for the message of score final 
   

    private int score = 0; // this is a numerical data value of our score 
    private float timeRemaining = 0; // numerical time remaining for the game
    private bool gameRunning = false;

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");

	} // End of Start()
	
	// Update is called once per frame
	void Update () {

        Debug.Log("Method Called");

        // update the numerical time remaining 
        timeRemaining = timeRemaining - Time.deltaTime;

        // update the visual time remaining 
        timerText.text = (Mathf.CeilToInt (timeRemaining)).ToString(); 

        // check if we have run out of time 
        if (timeRemaining <= 0)
        {
            // only do this if we just now hit gameover
            if (gameRunning == true)

            {
                //play the game over sound 
                gameOverSound.Play();

                // show the player their scsore 
                messageText.text = "Time up! Final Score = " + score.ToString();


            } // end if game running == true

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
        else
        {
            // game is not running and we click the button 
            gameRunning = true;

            // set the timer to the full length of our game 
            timeRemaining = gameLength;

            // tell the player how to play 
            messageText.text = "mash the button!!!!";

            // update score display 
            scoreText.text = score.ToString();
        }

    } // end of mouse down()


} // End of button masher class 
