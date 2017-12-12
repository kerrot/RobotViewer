using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewInput : MonoBehaviour {
	[SerializeField] float rTrigger1;
	[SerializeField] float rTrigger2;
	[SerializeField] float lTrigger1;
	[SerializeField] float lTrigger2;

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
		if (OVRInput.GetDown(OVRInput.RawButton.A)) {
			Debug.Log("Aボタンを押した");
		}
		if (OVRInput.GetDown(OVRInput.RawButton.B)) {
			Debug.Log("Bボタンを押した");
		}
		if (OVRInput.GetDown(OVRInput.RawButton.X)) {
			Debug.Log("Xボタンを押した");
		}
		if (OVRInput.GetDown(OVRInput.RawButton.Y)) {
			Debug.Log("Yボタンを押した");
		}
		if (OVRInput.GetDown(OVRInput.RawButton.Start)) {
			Debug.Log("メニューボタン（左アナログスティックの下にある）を押した");
		}

		if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)) {
			Debug.Log("右人差し指トリガーを押した");
		}
		if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger)) {
			Debug.Log("右中指トリガーを押した");
		}
		if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger)) {
			Debug.Log("左人差し指トリガーを押した");
		}
		if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger)) {
			Debug.Log("左中指トリガーを押した");
		}


		rTrigger1 = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);
		rTrigger2 = OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger);
		lTrigger1 = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger);
		lTrigger2 = OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger);


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
