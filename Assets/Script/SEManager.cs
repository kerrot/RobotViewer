using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour {
    [SerializeField] AudioClip btnSE;

    AudioSource au;

    private void Awake()
    {
        au = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start () {
        
	}

    public void PlayBtnSE()
    {
        if (au)
        {
            au.clip = btnSE;
            au.Play();
        }
    }
}
