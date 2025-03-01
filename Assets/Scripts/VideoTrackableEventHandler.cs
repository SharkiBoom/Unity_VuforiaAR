﻿/*===============================================================================
Copyright (c) 2017 PTC Inc. All Rights Reserved.
 
Vuforia is a trademark of PTC Inc., registered in the United States and other
countries.
===============================================================================*/

public class VideoTrackableEventHandler : DefaultTrackableEventHandler
{
	#region PROTECTED_METHODS

	protected override void OnTrackingLost()
	{
		mTrackableBehaviour.GetComponentInChildren<VideoController>().Pause();

		base.OnTrackingLost();
	}



	protected override void OnTrackingFound()
	{
		mTrackableBehaviour.GetComponentInChildren<VideoController>().Play();

		base.OnTrackingFound();
		
	}

	#endregion // PROTECTED_METHODS
}