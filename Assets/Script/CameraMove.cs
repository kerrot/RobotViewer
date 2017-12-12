using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
	[SerializeField] float moveRate = 1;
	[SerializeField] float rotateRate = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float dx = Input.GetAxis ("Horizontal");
        float dy = Input.GetAxis ("Vertical");

		transform.position += Camera.main.transform.forward * dy * moveRate; 
		transform.Rotate(0, dx * rotateRate, 0);
	}
}
