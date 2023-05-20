using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
