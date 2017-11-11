using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerArmController : MonoBehaviour {

    public Image reticle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(reticle.transform.position);
        transform.LookAt(reticle.transform.position);
	}
}
