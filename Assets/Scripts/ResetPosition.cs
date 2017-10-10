using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Vuforia;


public class ResetPosition : MonoBehaviour {

	Vector3 VernierinitialPosition;
	Vector3 MicrometerinitialPosition;
	Vector3 PenduluminitialPosition;
	Vector3 VernierinitialScale;
	Vector3 MicrometerinitialScale; 
	Vector3 PenduluminitialScale;
	Quaternion MicrometerinitialRotation;
	Quaternion VernierinitialRotation;
	Quaternion PenduluminitialRotation;


	// Use this for initialization
	void Start () {
		VernierinitialPosition = GameObject.Find ("VernierObj").GetComponent<InitalXYZ> ().initialPosition;
		MicrometerinitialPosition = GameObject.Find ("MicrometerObj").GetComponent<InitalXYZ> ().initialPosition;
		PenduluminitialPosition = GameObject.Find ("PendulumObj").GetComponent<InitalXYZ> ().initialPosition;	
		VernierinitialScale = GameObject.Find ("VernierObj").GetComponent<InitalXYZ> ().initialScale;
		MicrometerinitialScale = GameObject.Find ("MicrometerObj").GetComponent<InitalXYZ> ().initialScale;
		PenduluminitialScale = GameObject.Find ("PendulumObj").GetComponent<InitalXYZ> ().initialScale;	
		VernierinitialRotation = GameObject.Find ("VernierObj").GetComponent<InitalXYZ> ().initialRotation;
		MicrometerinitialRotation = GameObject.Find ("MicrometerObj").GetComponent<InitalXYZ> ().initialRotation;
		PenduluminitialRotation = GameObject.Find ("PendulumObj").GetComponent<InitalXYZ> ().initialRotation;

		
	}

	public void reset(){
		Debug.Log ("funcionaaa");
		if (GameObject.Find("VernierQR").GetComponent<ImageTargetPlayAudio>().AudioFlag == 1) {
			Debug.Log ("entroooo");
			GameObject.Find ("VernierObj").transform.position = VernierinitialPosition;
			GameObject.Find ("VernierObj").transform.localScale = VernierinitialScale;
			GameObject.Find ("VernierObj").transform.rotation = VernierinitialRotation;
		}else if(GameObject.Find("MicrometerQR").GetComponent<ImageTargetPlayAudio>().AudioFlag == 1){
			GameObject.Find ("MicrometerObj").transform.position = MicrometerinitialPosition;
			GameObject.Find ("MicrometerObj").transform.localScale = MicrometerinitialScale;
			GameObject.Find ("MicrometerObj").transform.rotation = MicrometerinitialRotation;
		}else if(GameObject.Find("PendulumQR").GetComponent<ImageTargetPlayAudio>().AudioFlag == 1){
			GameObject.Find ("PendulumObj").transform.position = PenduluminitialPosition;
			GameObject.Find ("PendulumObj").transform.localScale = PenduluminitialScale;
			GameObject.Find ("PendulumObj").transform.rotation = PenduluminitialRotation;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
