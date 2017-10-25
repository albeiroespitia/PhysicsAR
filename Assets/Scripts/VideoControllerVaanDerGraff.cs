using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VideoControllerVaanDerGraff : MonoBehaviour {
	
	float Timer = 56.0f;
	ImageTargetPlayAudio imageTargetPlayAudio;

		// Use this for initialization
	void Start () {
		imageTargetPlayAudio = GetComponent<ImageTargetPlayAudio> (); 
	}

	// Update is called once per frame
	void Update () {
		
		if (imageTargetPlayAudio.AudioFlag == 1) {
			Timer -= Time.deltaTime;
			if (Timer < 0) {
				Handheld.PlayFullScreenMovie ("VideoVanDerGraff.mp4", Color.black, FullScreenMovieControlMode.Hidden);
			}

		} else {
			Timer = 56.0f;
		}

	}
}
