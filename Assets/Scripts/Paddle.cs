using UnityEngine;
using System.Collections;

/* Paddle base class:
 * - Define default parameters: speed, upper bound, lower bound
 * - Process keyboard input
 * - Limit paddle bounds
 */

public class Paddle : MonoBehaviour {
    public float speed = 20.0f;
    public float upperBound = 13f;
    public float lowerBound = -11f;
    public string keyUp;
    public string keyDown;

    public void Update () {
        if (Input.GetButton(keyUp))
        {
            transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);
        }
        if (Input.GetButton(keyDown))
        {
            transform.Translate(new Vector3(0, -speed, 0) * Time.deltaTime);
        }
        if (transform.position.y > upperBound)
        {
            transform.position = new Vector3(transform.position.x, upperBound, transform.position.z);
        }
        if (transform.position.y < lowerBound)
        {
            transform.position = new Vector3(transform.position.x, lowerBound, transform.position.z);
        }
    }
}

