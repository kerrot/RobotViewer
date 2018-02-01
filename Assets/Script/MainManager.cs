using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MainManager : MonoBehaviour {

	[SerializeField] private DroneControl[] drones;
    [SerializeField] private GameObject VRCenter;

    // Use this for initialization
    void Start() {
		
    }

    // Update is called once per frame
    void Update() {
        if (OVRInput.GetDown(OVRInput.RawButton.B) || Input.GetKeyDown(KeyCode.F1))
        {
            VRCenter.SetActive(!VRCenter.activeSelf);
        }
    }

    public void ChangeToNext(GameObject cameraBase, bool fade = true)
    {
		int index = 0;
		DroneControl drone = RayCastBase.GetCurrent() as DroneControl;
		if (drone)
		{
			index = drones.ToList().IndexOf(drone);
		}

		if (index >= 0 && drones.Length > 0)
		{
            if (fade)
            {
                drones[index].Action(cameraBase);
            }
            else
            {
                drones[index].ActionWithoutFade(cameraBase);
            }
		}
    }

	public void Refind()
	{
		drones = GameObject.FindObjectsOfType<DroneControl>();
	}
}
