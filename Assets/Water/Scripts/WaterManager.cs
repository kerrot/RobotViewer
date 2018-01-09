using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UTJ;

public class WaterManager : MonoBehaviour {

    public bool water_surface_distortion_ = true;
    public bool water_surface_line_render_ = false;
    public Material water_surface_input_material_;
    public Material water_splash_material_;

    public GameObject inputObj;

    private int rendering_front_ = 0;
    private float update_time_ = 0.0f;

    private Vector3 inputPosition;

    // Use this for initialization
    void Start () {
        WaterSurface.Instance.init(water_surface_input_material_, water_surface_distortion_, water_surface_line_render_);
        WaterSurfaceRenderer.Instance.init(Camera.main.transform);
        WaterSplash.Instance.init(water_splash_material_, WaterSurfaceRenderer.Instance.getReflectionTexture());
        WaterSplashRenderer.Instance.init(WaterSplash.Instance);
    }

    // Update is called once per frame
    void Update() {
        WaterSurface.Instance.renderUpdate(rendering_front_);
        WaterSplash.Instance.renderUpdate(rendering_front_);

        WaterSurface.Instance.render(rendering_front_);
        WaterSurfaceRenderer.Instance.render(update_time_);
        WaterSplash.Instance.render(rendering_front_, Camera.main, update_time_);

        update_time_ += 0.02f;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            inputPosition = inputObj.transform.position;
            WaterSurface.Instance.makeBump(ref inputPosition, -0.55f /* value */, 1.6f /* size */);
        }
    }
}
