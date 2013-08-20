using UnityEngine;
using System.Collections;

/* Paddle base class:
 * - Define default parameters: speed, upper bound, lower bound
 * - Process keyboard input
 * - Limit paddle bounds
 */

public class Paddle : MonoBehaviour {
    public float speed = 10.0f;
    public float upperBound = 13f;
    public float lowerBound = -11f;
    public string keyUp;
    public string keyDown;

    void processInput()
    {
        if (Input.GetButton(keyUp))
        {
            transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);
        }
        if (Input.GetButton(keyDown))
        {
            transform.Translate(new Vector3(0, -speed, 0) * Time.deltaTime);
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            //transform.Translate(new Vector3(0, speed * Time.deltaTime * touchDeltaPosition.y, 0));
            if(touchDeltaPosition.y > 0) transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
            else transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); 
        }
    }

    protected void checkBounds()
    {
        if (transform.position.y > upperBound)
        {
            transform.position = new Vector3(transform.position.x, upperBound, transform.position.z);
        }
        if (transform.position.y < lowerBound)
        {
            transform.position = new Vector3(transform.position.x, lowerBound, transform.position.z);
        }
    }

    protected virtual void Update () {
        processInput();
        checkBounds();
    }
}

