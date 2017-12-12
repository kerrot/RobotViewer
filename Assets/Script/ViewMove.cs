using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewMove : MonoBehaviour {
	[SerializeField] float moveRate = 1;
	[SerializeField] float rotateRate = 1;

	[SerializeField] GameObject ori;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
		float dx = Input.GetAxis ("Horizontal");
        float dy = Input.GetAxis ("Vertical");

		bool isShift = Input.GetKey(KeyCode.LeftShift);

		if (isShift)
		{
			ori.transform.localPosition += Vector3.up * moveRate * dy;
			ori.transform.localPosition += Vector3.right * moveRate * dx;
		}
		else
		{
			ori.transform.localPosition += Vector3.forward * moveRate * dy;
			transform.Rotate(0, dx * rotateRate, 0);
		}

		if (Input.GetButtonDown("Jump"))
		{
			ori.transform.localPosition = Vector3.zero;
		}
	}
}
