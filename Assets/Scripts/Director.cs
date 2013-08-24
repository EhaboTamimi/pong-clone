using UnityEngine;
using System.Collections;

public class Director : MonoBehaviour {

    public GameObject displayP1, displayP2;

    void Awake()
    {
        // Setting initial scores to 0
        GameObject.Find("displayP1").GetComponent<ScoreDirector>().SetNumber(0);
        GameObject.Find("displayP2").GetComponent<ScoreDirector>().SetNumber(0);
    }
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
