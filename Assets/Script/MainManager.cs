using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MainManager : MonoBehaviour {

	[SerializeField] private DroneControl[] drones;

    // Use this for initialization
    void Start() {
		
    }

    // Update is called once per frame
    void Update() {

    }

    public void ChangeToNext(GameObject cameraBase)
    {
		int index = 0;
		DroneControl drone = RayCastBase.GetCurrent() as DroneControl;
		if (drone)
		{
			index = drones.ToList().IndexOf(drone);
		}

		if (index >= 0 && drones.Length > 0)
		{
			drones[index].Action(cameraBase);
		}
    }

	public void Refind()
	{
		drones = GameObject.FindObjectsOfType<DroneControl>();
	}
}
