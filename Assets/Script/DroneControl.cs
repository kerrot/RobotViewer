using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneControl : RayCastBase {

	[SerializeField] protected VRTeleportHelper CameraObj;

	protected override void DoAction(GameObject cameraBase)
	{
		cameraBase.transform.position = CameraObj.GetTeleportPosition();
		cameraBase.transform.rotation = CameraObj.transform.rotation;
	}
}
