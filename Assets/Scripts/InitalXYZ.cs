using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitalXYZ : MonoBehaviour {

	public Vector3 initialPosition;
	public Vector3 initialScale;
	public Quaternion initialRotation;

	// Use this for initialization
	void Awake(){
		initialPosition = transform.position;
		initialScale = transform.localScale;
		initialRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
