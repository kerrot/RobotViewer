using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneControl : RayCastBase {

	public static DroneControl current = null;

	public override void Action(GameObject cameraBase)
	{
		cameraBase.transform.position = Model.transform.position;
		cameraBase.transform.rotation = Model.transform.rotation;

		if (current)
		{
			current.Model.SetActive(true);
		}

		current = this;

		Model.SetActive(false);
	}
}
