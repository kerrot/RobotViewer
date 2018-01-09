using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UTJ;

public class RobotFly : MonoBehaviour {
	
	[SerializeField] private float waveTime = 0.1f;
	[SerializeField] private float waveSize = -0.55f;
	[SerializeField] private float waveRange = 1.6f;
	[SerializeField] private float flySpeed = 1f;


	private float last = 0f;
	private Vector3 inputPosition;
	
	// Update is called once per frame
	void Update () 
	{
		inputPosition.z += flySpeed;
		inputPosition.z %= 100;
		inputPosition.y = transform.position.y;
		transform.position = inputPosition;


		if (Time.time - last > waveTime)
		//if (Input.GetKeyDown(KeyCode.Space))
		{
			inputPosition.y = 0;
			WaterSurface.Instance.makeBump(ref inputPosition, waveSize, waveRange);

			last = Time.time;
		}
	}
}
