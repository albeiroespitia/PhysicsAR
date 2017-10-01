using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace Lean.Touch{

	public class EnabledInteraction : MonoBehaviour, ITrackableEventHandler{

		private TrackableBehaviour mTrackableBehaviour;

		void Start(){
			mTrackableBehaviour = GetComponent<TrackableBehaviour>();
			if (mTrackableBehaviour){
				mTrackableBehaviour.RegisterTrackableEventHandler(this);
			}
		}

		public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus){
			LeanSelectable selectable = GetComponentInChildren<LeanSelectable> ();
			if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED){
				selectable.Select ();
			}else{
				selectable.Deselect ();
			}
		}

	}

}