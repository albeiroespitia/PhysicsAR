using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VideoControllerMicrometer : MonoBehaviour {

	float Timer = 5.0f;
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
				Handheld.PlayFullScreenMovie ("VideoMicrometer.mp4", Color.black, FullScreenMovieControlMode.Hidden);
			}
			
		} else {
			Timer = 5.0f;
		}

	}
}
