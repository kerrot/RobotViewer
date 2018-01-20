using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleproter : MonoBehaviour {

	[SerializeField] private float viewRange = 1f;
	
	DroneControl current = null;

	// Update is called once per frame
	void Update () 
	{
		RaycastHit hit;

        if (Physics.SphereCast(Camera.main.transform.position, viewRange, Camera.main.transform.forward, out hit)) 
		{
        	DroneControl drone = hit.collider.gameObject.GetComponent<DroneControl>();
			if (drone && current == null)
			{
				drone.OnFocus();
				current = drone;
			}
        }
		else if (current != null)
		{
			current.LostFocus();
			current = null;
		}


	}
}
