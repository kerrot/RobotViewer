using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : RayCastBase {
    [SerializeField] private GameObject selfScene;
    [SerializeField] private GameObject targetScene;
    [SerializeField] private Material skybox;

    protected override void DoAction(GameObject cameraBase)
    {
        selfScene.SetActive(false);
        targetScene.SetActive(true);

        RenderSettings.skybox = skybox;

		MainManager Main = GameObject.FindObjectOfType<MainManager>( );
        if (Main) {
            Main.Refind();

            Teleproter tele = GameObject.FindObjectOfType<Teleproter>();
            if (tele)
            {
                Main.ChangeToNext(tele.gameObject, false);
            }
		}
	}
}
