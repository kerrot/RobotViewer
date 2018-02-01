using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {
	[SerializeField] private Teleproter tele;

	private void Start ( ) {
		MainManager Main = GameObject.FindObjectOfType<MainManager>( );
		if ( Main ) {
			Main.Refind( );

			tele = GameObject.FindObjectOfType<Teleproter>( );
			if (tele)
			{
				Main.ChangeToNext( tele.gameObject , false);
			}
		}
	}

	// Update is called once per frame
	void Update () {
        tele = GameObject.FindObjectOfType<Teleproter>();
        if (tele)
        {
            transform.position = tele.transform.position;
            transform.rotation = tele.transform.rotation;
        }
	}
}
