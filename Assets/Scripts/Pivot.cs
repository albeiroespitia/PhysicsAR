using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace Vuforia{

	public class Pivot : MonoBehaviour,
	ITrackableEventHandler
	{
		
		private TrackableBehaviour mTrackableBehaviour;


		void Awake(){
			
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
				GameObject.Find ("Touch").transform.position = new Vector3 (0f, 0f, 4599.747f);

			}
			else
			{
				// Stop audio when target is lost

			}
		}   
	}

}