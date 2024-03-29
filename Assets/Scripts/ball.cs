﻿using UnityEngine;
using System.Collections;


public class Ball : MonoBehaviour {
    // constant speed
    // TODO: Y speed is OK, but what about X speed?
    public float cSpeed = 10.0f;
    // smoothing factors
    public float sFactor = 10.0f;
    // goals
    float leftGoal = -19.0f;
    float rightGoal = 19.0f;

    // scores
    static public int player1Score = 0;
    static public int player2Score = 0;
    ScoreDirector scoreP1, scoreP2;

    public void Awake()
    {
        scoreP1 = GameObject.Find("displayP1").GetComponent<ScoreDirector>();
        scoreP2 = GameObject.Find("displayP2").GetComponent<ScoreDirector>();
    }

    public void Reset()
    {
        transform.position = new Vector3(0, 0, 0);
        rigidbody.velocity = Vector3.zero;
        float xForce = cSpeed;
        float yForce = cSpeed;
       
        switch(Random.Range(0, 1)){
            case 0: rigidbody.AddForce(-xForce, yForce, 0); break;
            case 1: rigidbody.AddForce(-xForce, -yForce, 0); break;
        }
    }

	void Start () {
	}
	
	void FixedUpdate () {
        // current velocity
        Vector3 cVel = rigidbody.velocity;
        if (cVel == Vector3.zero) return;
        // normalized vector * constant speed
        Vector3 tVel = cVel.normalized * cSpeed;
        if (tVel.x > 0) tVel.x = cSpeed;
        else tVel.x = -cSpeed;
        if (tVel.y > 0) tVel.y = cSpeed;
        else tVel.y = -cSpeed;

        rigidbody.velocity = Vector3.Lerp(cVel, tVel, Time.deltaTime * sFactor);
    }

    void Update(){
        if (transform.position.x < leftGoal)
        {
            player2Score++;
            scoreP2.CurrentScore = player2Score;
            Reset();
        }
        if (transform.position.x > rightGoal)
        {
            player1Score++;
            scoreP1.CurrentScore = player1Score;
            Reset();
        }
        GUIText score1 = GameObject.Find("score1").guiText;
        GUIText score2 = GameObject.Find("score2").guiText;
        score1.text = "Player 1: " + player1Score.ToString();
        score2.text = "Player 2: " + player2Score.ToString();
	}
}

