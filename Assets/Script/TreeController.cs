using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour {

    // min and max scale values
    public float minScale = 0.7f;
    public float maxScale = 2.5f;

	// Use this for initialization
	void Start () {
        // set the Y position to ground level
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);

        // get a random scale
        float scale = Random.Range(minScale, maxScale);

        // set the new scale
        transform.localScale *= scale;

        // get a random rotation value
        float rotationY = Random.Range(0, 360);

        // rotate about "up" axes
        transform.Rotate(0, rotationY, 0, Space.World);

	}// end of Start
	
	// Update is called once per frame
	void Update () {
		
	}
}
