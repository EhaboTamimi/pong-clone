using UnityEngine;
using System.Collections;

public class Director : MonoBehaviour {

    public Ball ball;
    bool running;
    GUIText initialText, help1;

    void Awake()
    {
        // Setting initial scores to 0
        GameObject.Find("displayP1").GetComponent<ScoreDirector>().CurrentScore = 0;
        GameObject.Find("displayP2").GetComponent<ScoreDirector>().CurrentScore = 0;
        ball = GameObject.Find("ball").GetComponent<Ball>();
        // the ball will not move when the game loads
        running = false;
    }
    
    
	void Start () {
        initialText = GameObject.Find("initial text").GetComponent<GUIText>();
        help1 = GameObject.Find("help1").GetComponent<GUIText>();
        if (Application.platform == RuntimePlatform.Android)
        {
            initialText.text = "Touch the screen to start";
            help1.text = "left paddle: swipe";
        }
        else
        {
            initialText.text = "Press enter to start";
            help1.text = "left paddle: W - up S - down";
        }
	}
	
	
	void Update () {
        if (!running)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                // When return is pressed, the ball starts moving
                running = true;
                ball.Reset();
                initialText.gameObject.SetActive(false);
            }
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                // When the user touches the screen, the ball starts moving
                running = true;
                ball.Reset();
                initialText.gameObject.SetActive(false);
            }
        }
	}
}
