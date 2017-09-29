using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace Vuforia{

public class ImageTargetPlayAudio : MonoBehaviour,
ITrackableEventHandler
{
		private AudioSource audioSource;	
	private TrackableBehaviour mTrackableBehaviour;

	
		void Awake(){
			audioSource = GetComponent<AudioSource> ();
		}

	void Start()
	{
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			// Play audio when target is found
				audioSource.Play();
		}
		else
		{
			// Stop audio when target is lost
				audioSource.Stop();
		}
	}   
}

}