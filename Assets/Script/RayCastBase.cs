using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RayCastBase : MonoBehaviour {

	[SerializeField] protected GameObject Hit;
	[SerializeField] protected GameObject Model;
	[SerializeField] protected float scaleSize = 1.5f;

	protected static RayCastBase Current = null;
	public static RayCastBase GetCurrent() { return Current; }

    private bool acting = false;
    private FadeInOutManager fad;

    public void OnFocus()
	{
		Hit.SetActive(true);
		Model.transform.localScale = Vector3.one * scaleSize;
	}

	public void LostFocus()
	{
		Hit.SetActive(false);
		Model.transform.localScale = Vector3.one;
	}

    public void Action(GameObject cameraBase)
    {
        if (acting)
        {
            return;
        }

        fad = GameObject.FindObjectOfType<FadeInOutManager>();
        if (fad)
        {
            if (fad.FadeOut())
            {
                fad.OnFadeOutEnd += FadeEndAction;

                SEManager se = GameObject.FindObjectOfType<SEManager>();
                if (se)
                {
                    se.PlayBtnSE();
                }

                acting = true;
            }
        }
    }

    public void ActionWithoutFade(GameObject cameraBase)
    {
        if (cameraBase != null)
        {
            if (Current != null)
            {
                Current.gameObject.SetActive(true);
            }

            gameObject.SetActive(false);
            Current = this;

            DoAction(cameraBase.gameObject);
        }
    }

    private void FadeEndAction()
    {
        if (fad)
        {
            if (fad.FadeOut())
            {
                fad.OnFadeOutEnd -= FadeEndAction;
            }
        }

        Teleproter cameraBase = GameObject.FindObjectOfType<Teleproter>();
        if (cameraBase)
        {
            ActionWithoutFade(cameraBase.gameObject);
        }

        if (fad)
        {
            fad.FadeIn();
        }

        acting = false;
    }

	protected abstract void DoAction(GameObject cameraBase);
}
