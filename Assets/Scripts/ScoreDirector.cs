using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScoreDirector : MonoBehaviour
{

    //Dictionary<int, GameObject> segments;
    Dictionary<int, Transform> segments;
    //Dictionary<int, Renderer> segments;

    public int currentScore;
    public int CurrentScore { get { return this.currentScore; } set { SetNumber(value); } }

    void Awake()
    {
        //Store local reference to all segments in a array
        //Note that arrays are 0-based on C#, so first segment
        //corresponds to segments[0], second to segments[1], and so on

        segments = new Dictionary<int, Transform>();
        segments[1] = transform.Find("seg1").GetComponent<Transform>();
        segments[2] = transform.Find("seg2").GetComponent<Transform>();
        segments[3] = transform.Find("seg3").GetComponent<Transform>();
        segments[4] = transform.Find("seg4").GetComponent<Transform>();
        segments[5] = transform.Find("seg5").GetComponent<Transform>();
        segments[6] = transform.Find("seg6").GetComponent<Transform>();
        segments[7] = transform.Find("seg7").GetComponent<Transform>();

    }

    public void SetNumber(int n)
    {
        {
            // naïve method: just check by the number passed and enable/disable 
            // the segments; lots of redundancy, but it gets the job done
            switch (n)
            {
                case 0:
                    segments[1].gameObject.SetActive(true);
                    segments[2].gameObject.SetActive(true);
                    segments[3].gameObject.SetActive(true);
                    segments[4].gameObject.SetActive(true);
                    segments[5].gameObject.SetActive(true);
                    segments[6].gameObject.SetActive(true);
                    segments[7].gameObject.SetActive(false);
                    break;
                case 1:
                    segments[1].gameObject.SetActive(false);
                    segments[2].gameObject.SetActive(false);
                    segments[3].gameObject.SetActive(true);
                    segments[4].gameObject.SetActive(true);
                    segments[5].gameObject.SetActive(false);
                    segments[6].gameObject.SetActive(false);
                    segments[7].gameObject.SetActive(false);
                    break;
                case 2:
                    segments[1].gameObject.SetActive(false);
                    segments[2].gameObject.SetActive(true);
                    segments[3].gameObject.SetActive(true);
                    segments[4].gameObject.SetActive(false);
                    segments[5].gameObject.SetActive(true);
                    segments[6].gameObject.SetActive(true);
                    segments[7].gameObject.SetActive(true);
                    break;
                case 3:
                    segments[1].gameObject.SetActive(false);
                    segments[2].gameObject.SetActive(true);
                    segments[3].gameObject.SetActive(true);
                    segments[4].gameObject.SetActive(true);
                    segments[5].gameObject.SetActive(true);
                    segments[6].gameObject.SetActive(false);
                    segments[7].gameObject.SetActive(true);
                    break;
                case 4:
                    segments[1].gameObject.SetActive(true);
                    segments[2].gameObject.SetActive(false);
                    segments[3].gameObject.SetActive(true);
                    segments[4].gameObject.SetActive(true);
                    segments[5].gameObject.SetActive(false);
                    segments[6].gameObject.SetActive(false);
                    segments[7].gameObject.SetActive(true);
                    break;
                case 5:
                    segments[1].gameObject.SetActive(true);
                    segments[2].gameObject.SetActive(true);
                    segments[3].gameObject.SetActive(false);
                    segments[4].gameObject.SetActive(true);
                    segments[5].gameObject.SetActive(true);
                    segments[6].gameObject.SetActive(false);
                    segments[7].gameObject.SetActive(true);
                    break;
                case 6:
                    segments[1].gameObject.SetActive(true);
                    segments[2].gameObject.SetActive(true);
                    segments[3].gameObject.SetActive(false);
                    segments[4].gameObject.SetActive(true);
                    segments[5].gameObject.SetActive(true);
                    segments[6].gameObject.SetActive(true);
                    segments[7].gameObject.SetActive(true);
                    break;
                case 7:
                    segments[1].gameObject.SetActive(false);
                    segments[2].gameObject.SetActive(true);
                    segments[3].gameObject.SetActive(true);
                    segments[4].gameObject.SetActive(true);
                    segments[5].gameObject.SetActive(false);
                    segments[6].gameObject.SetActive(false);
                    segments[7].gameObject.SetActive(false);
                    break;
                case 8:
                    segments[1].gameObject.SetActive(true);
                    segments[2].gameObject.SetActive(true);
                    segments[3].gameObject.SetActive(true);
                    segments[4].gameObject.SetActive(true);
                    segments[5].gameObject.SetActive(true);
                    segments[6].gameObject.SetActive(true);
                    segments[7].gameObject.SetActive(true);
                    break;
                case 9:
                    segments[1].gameObject.SetActive(true);
                    segments[2].gameObject.SetActive(true);
                    segments[3].gameObject.SetActive(true);
                    segments[4].gameObject.SetActive(true);
                    segments[5].gameObject.SetActive(true);
                    segments[6].gameObject.SetActive(false);
                    segments[7].gameObject.SetActive(true);
                    break;

            }

        }
    }
}

