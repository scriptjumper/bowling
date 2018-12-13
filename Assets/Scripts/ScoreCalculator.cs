using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour {

	float score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var pins = GameObject.FindGameObjectsWithTag("Pin");
	}

	void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
			score += 1;
		};

		Debug.Log(score);
    }
}
