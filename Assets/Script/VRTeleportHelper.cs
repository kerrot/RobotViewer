using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRTeleportHelper : MonoBehaviour {

	[SerializeField] private GameObject VRBase;

	public Vector3 GetTeleportPosition()
	{
		VRBase.transform.localPosition = - Camera.main.transform.localPosition;
		return VRBase.transform.position;
	}
}
