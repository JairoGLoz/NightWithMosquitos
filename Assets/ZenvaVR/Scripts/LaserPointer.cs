using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

namespace ZenvaVR
{
    [RequireComponent(typeof(LineRenderer))]
    public class LaserPointer : MonoBehaviour
    {

        // line renderer component
        LineRenderer lineRend;

        // reticle
        Reticle reticle;

        // points
        Vector3[] laserPoints;

        void Awake()
        {
            // get component
            lineRend = GetComponent<LineRenderer>();

            // get reticle
            reticle = FindObjectOfType<Reticle>();

            if(reticle == null)
            {
                Debug.LogError("There needs to be a reticle in the scene");
            }

            // init array
            laserPoints = new Vector3[2];
        }

        // Update is called once per frame
        void Update()
        {
            // start and end point of the laser
            laserPoints[0] = transform.position;
            laserPoints[1] = reticle.ReticleTransform.position;

            // set line renderer points
            lineRend.SetPositions(laserPoints);
        }
    }
}