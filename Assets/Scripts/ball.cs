using UnityEngine;
using System.Collections;


public class ball : MonoBehaviour {
    // constant speed
    // TODO: Y speed is OK, but what about X speed?
    public float cSpeed = 10.0f;
    // smoothing factor
    public float sFactor = 10.0f;
    // goals
    float leftGoal = -19.0f;
    float rightGoal = 19.0f;

    // scores
    static public int player1Score = 0;
    static public int player2Score = 0;

    public void Reset()
    {
        transform.position = new Vector3(0, 0, 0);
        rigidbody.velocity = Vector3.zero;
        switch(Random.Range(0, 3)){
            case 0: rigidbody.AddForce(10, 10, 0); break;
            case 1: rigidbody.AddForce(-10, 10, 0); break;
            case 2: rigidbody.AddForce(10, -10, 0); break;
            case 3: rigidbody.AddForce(-10, -10, 0); break;
        }
    }

	// Use this for initialization
	void Start () {
        // initial force
        Reset();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        // current velocity
        Vector3 cVel = rigidbody.velocity;
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
            Reset();
        }
        if (transform.position.x > rightGoal)
        {
            player1Score++;
            Reset();
        }
        
        GUIText score1 = GameObject.Find("score1").guiText;
        GUIText score2 = GameObject.Find("score2").guiText;
        score1.text = "Player 1: " + player1Score.ToString();
        score2.text = "Player 2: " + player2Score.ToString();
	}
}

