using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour {

	Vector3 initialPosition;
	Vector3 initialScale;
	Quaternion initialRotation;

	void Awake(){
		initialPosition = transform.position;
		initialScale = transform.localScale;
		initialRotation = transform.rotation;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void resetPosition(){
		transform.position = initialPosition;
		transform.rotation = initialRotation;
		transform.localScale = initialScale;
	}
}
