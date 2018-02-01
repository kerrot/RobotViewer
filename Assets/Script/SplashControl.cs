using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UTJ;

public class SplashControl : MonoBehaviour {
    public Camera camera_;
    public Material material_;

    private float time_ = 0f;

    // Use this for initialization
    private void OnEnable()
    {
        WaterSplash.Instance.init(material_, null /* reflection texture */);
        var col = new Color(1f, 1f, 1f);
        WaterSplash.Instance.SetBaseColor(ref col);
        WaterSplash.Instance.SetGravity(0f);

    }

    // Update is called once per frame
    void Update()
    {
        WaterSplash.Instance.render(0 /* front */, camera_, time_);

        var mesh = WaterSplash.Instance.getMesh();
        GetComponent<MeshFilter>().sharedMesh = mesh;
        var material = WaterSplash.Instance.getMaterial();
        GetComponent<MeshRenderer>().material = material;

        var pos = new Vector3(0f, 0f, 0f);
        var vel = new Vector3(0f, 0f, 0f);
        spawn(ref pos, ref vel);

        time_ += 1f / 60f;
    }

    private void spawn(ref Vector3 pos, ref Vector3 velocity)
    {
        WaterSplash.Instance.update(time_);
        WaterSplash.Instance.spawn(ref pos, ref velocity, time_);
        WaterSplash.Instance.renderUpdate(0 /* front */);
    }
}
