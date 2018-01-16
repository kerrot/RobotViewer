using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneControl : MonoBehaviour {

	[SerializeField] private GameObject Hit;
	[SerializeField] private GameObject Model;
	[SerializeField] private float scaleSize = 1.5f;
	[SerializeField] private float viewRange = 1f;

	public static DroneControl Current = null;

	private void Awake( ) 
	{

	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		RaycastHit hit;
        
        if (Physics.SphereCast(Camera.main.transform.position, viewRange, Camera.main.transform.forward, out hit)) 
		{
        	
        }
		else
		{

		}
	}
}
