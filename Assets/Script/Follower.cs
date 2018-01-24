using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        Teleproter tele = GameObject.FindObjectOfType<Teleproter>();
        if (tele)
        {
            transform.position = tele.transform.position;
            transform.rotation = tele.transform.rotation;
        }
	}
}
