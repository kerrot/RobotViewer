using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RayCastBase : MonoBehaviour {

	[SerializeField] protected GameObject Hit;
	[SerializeField] protected GameObject Model;
	[SerializeField] protected float scaleSize = 1.5f;

	protected static RayCastBase Current = null;
	public static RayCastBase GetCurrent() { return Current; }

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

	public void Action(GameObject cameraBase)
	{
		if (cameraBase != null)
		{
			if (Current != null)
			{
				Current.gameObject.SetActive(true);
			}

			gameObject.SetActive(false);
			Current = this;

			DoAction(cameraBase);
		}
	}

	protected abstract void DoAction(GameObject cameraBase);
}
