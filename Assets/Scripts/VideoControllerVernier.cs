using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VideoControllerVernier : MonoBehaviour {

	float Timer = 35.0f;
	ImageTargetPlayAudio imageTargetPlayAudio;


	// Use this for initialization
	void Start () {
		imageTargetPlayAudio = GetComponent<ImageTargetPlayAudio> (); 
	}

	// Update is called once per frame
	void Update () {


		if (imageTargetPlayAudio.AudioFlag == 1) {
			Timer -= Time.deltaTime;
			Debug.Log (Timer);
			if (Timer < 0) {
				Debug.Log ("Entro");
				Handheld.PlayFullScreenMovie ("VideoVernier.mp4", Color.black, FullScreenMovieControlMode.Hidden);
			}

		} else {
			Timer = 35.0f;
		}

	}
}
