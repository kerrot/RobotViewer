using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneControl : RayCastBase {

	[SerializeField] protected GameObject CameraObj;

	protected override void DoAction(GameObject cameraBase)
	{
		cameraBase.transform.position = CameraObj.transform.position - Camera.main.transform.localPosition;
		cameraBase.transform.rotation = CameraObj.transform.rotation;
	}
}
