using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOutManager : MonoBehaviour {

	public delegate void FadeEvent();

	public FadeEvent OnFadeInEnd;
	public FadeEvent OnFadeOutEnd;

	Animator anim;
	bool fading = true;
	bool fadeState = false;

	private void Awake( ) {
		anim = GetComponent<Animator>();
	}

	void FadeInEnd()
	{
		fading = false;
		Debug.Log("FadeInEnd");

		if (OnFadeInEnd != null)
		{
			OnFadeInEnd.Invoke();
		}
	}

	void FadeOutEnd()
	{
		fading = false;
		Debug.Log("FadeOutEnd");

		if (OnFadeOutEnd != null)
		{
			OnFadeOutEnd.Invoke();
		}
	}

	public bool FadeIn()
	{
		if (!fading && fadeState)
		{
			anim.SetTrigger("FadeIn");
			fading = true;
			fadeState = false;

			return true;
		}

		return false;
	}

	public bool FadeOut()
	{
		if (!fading && !fadeState)
		{
            anim.SetTrigger("FadeOut");
            fading = true;
			fadeState = true;

			return true;
		}

		return false;
	}
}
