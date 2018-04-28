using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour {
	// Use this for initialization
	public GameObject right,left;
	void Start () {
		right.SetActive (true);
		left.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
