using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRStandardAssets.Utils;

public class PlayerArmController : MonoBehaviour {

    public Image reticle;
    public VRInput m_VRInput;
    public VREyeRaycaster m_EyeRaycaster;

	// Use this for initialization
	void Start () {
		
	}

    private void OnEnable()
    {
        m_VRInput.OnDown += HandleDown;
    }// end of OnEnable

    private void HandleDown()
    {
        // if there is an interactible currently being looked at
        MosquitoController shootingMosquito = m_EyeRaycaster.CurrentInteractible ?
            m_EyeRaycaster.CurrentInteractible.GetComponent<MosquitoController>() : null;

        // get target transform
        Transform target = shootingMosquito ? shootingMosquito.transform : null;

        // Start shooting coroutine
        StartCoroutine(Fire(target));
    }// end of HandleDown

    private IEnumerator Fire(Transform target)
    {
        // Play sound

        // show fire

        // Hit mosquito

        yield return null;
    }// end of fire

    // Update is called once per frame
    void Update () {
        transform.LookAt(reticle.transform.position);
	}
}
