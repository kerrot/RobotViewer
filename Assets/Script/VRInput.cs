using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRInput : MonoBehaviour {

	public Vector2 stickL;
	public Vector2 stickR;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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

		// 左手のアナログスティックの向きを取得
		stickL = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);
		// 右手のアナログスティックの向きを取得
		stickR = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
	}
}
