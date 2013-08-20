using UnityEngine;
using System.Collections;

public class player2 : Paddle {

    public GameObject ball;
    public bool cpu;
    public float sFactor = 20f;
    public float cSpeed = 10f;
    public Random rnd;

    void Awake()
    {
        ball = GameObject.Find("ball");
        cpu = true;
    }

    void Start()
    {
        keyUp = "UP2";
        keyDown = "DOWN2";
    }

    protected override void Update()
    {
        if (!cpu) base.Update();
    }
    
    void FixedUpdate()
    {
        if (cpu)
        {
            if (ball.rigidbody.velocity.y > 0)
            {
                transform.Translate(new Vector3(0, cSpeed * Time.deltaTime, 0));
            }
            else
            {
                transform.Translate(new Vector3(0, -cSpeed * Time.deltaTime, 0));
            }
            checkBounds();
        }
    }
}

