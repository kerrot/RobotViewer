using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewInput : MonoBehaviour {
	[SerializeField] float moveRate = 1;
	[SerializeField] float rotateRate = 1;

	GameObject ori;
	// Use this for initialization
	void Start () {
		ori = new GameObject();
		ori.transform.position = Camera.main.transform.position;
		ori.transform.LookAt(transform);
		ori.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		float dx = Input.GetAxis ("Horizontal");
        float dy = Input.GetAxis ("Vertical");

		bool isShift = Input.GetKey(KeyCode.LeftShift);
		
		if (isShift)
		{
			transform.position += ori.transform.right * dx * moveRate; 
			transform.position += ori.transform.up * dy * moveRate; 
		}
		else
		{
			transform.position += ori.transform.forward * dy * moveRate; 
			transform.Rotate(0, dx * rotateRate, 0);
		}

		if (Input.GetButtonDown("Jump"))
		{
			transform.position = ori.transform.position;
		}
	}
}
