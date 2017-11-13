using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRStandardAssets.Utils;

public class PlayerArmController : MonoBehaviour {

    public Image reticle;
    public VRInput m_VRInput;
    public VREyeRaycaster m_EyeRaycaster;
	public AudioSource m_GunAudio;
	public GameObject[] m_FlareMeshes;

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
		m_GunAudio.Play();

        // show fire
		// chose an index for a random flare mesh
		int randomFlareIndex = Random.Range(0, m_FlareMeshes.Length);
		m_FlareMeshes [randomFlareIndex].SetActive (true);

        yield return null;

		// hide fire
		m_FlareMeshes[randomFlareIndex].SetActive(false);
    }// end of fire

    // Update is called once per frame
    void Update () {
        transform.LookAt(reticle.transform.position);
	}
}
