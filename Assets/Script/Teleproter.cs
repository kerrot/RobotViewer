using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleproter : MonoBehaviour {

	[SerializeField] private float viewRange = 1f;
	
	RayCastBase current = null;

	// Update is called once per frame
	void Update () 
	{
		RaycastHit hit;

        if (Physics.SphereCast(Camera.main.transform.position, viewRange, Camera.main.transform.forward, out hit)) 
		{
        	RayCastBase obj = hit.collider.gameObject.GetComponent<RayCastBase>();
			if (obj && current == null)
			{
				obj.OnFocus();
				current = obj;
			}
        }
		else if (current != null)
		{
			current.LostFocus();
			current = null;
		}

		if (current != null && OVRInput.GetDown(OVRInput.RawButton.A))
		{
			current.Action(gameObject);
		}
	}
}
