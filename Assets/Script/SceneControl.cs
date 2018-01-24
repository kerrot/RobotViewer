using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : RayCastBase {
    [SerializeField] private GameObject selfScene;
    [SerializeField] private GameObject targetScene;
    [SerializeField] private Material skybox;

    private MainManager Main;

    private void Start()
    {
        Main = GameObject.FindObjectOfType<MainManager>();
    }

    protected override void DoAction(GameObject cameraBase)
    {
        selfScene.SetActive(false);
        targetScene.SetActive(true);

        RenderSettings.skybox = skybox;

        Main.ChangeToNext();
    }
}
