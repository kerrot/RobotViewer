using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RayCastBase : MonoBehaviour {

	[SerializeField] protected GameObject Hit;
	[SerializeField] protected GameObject Model;
	[SerializeField] protected float scaleSize = 1.5f;

	public void OnFocus()
	{
		Hit.SetActive(true);
		Model.transform.localScale = Vector3.one * scaleSize;
	}

	public void LostFocus()
	{
		Hit.SetActive(false);
		Model.transform.localScale = Vector3.one;
	}

	public abstract void Action(GameObject cameraBase);
}
