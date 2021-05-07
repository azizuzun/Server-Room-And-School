using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net
public class CameraZoom : MonoBehaviour
{
    /*Zoom Hızı*/
    public float zoomHizi;
    public float fovMin;
    public float fovMax;
    private Camera myCamera;
    // Use this for initialization
    void Start()
    {
        myCamera = GetComponent<Camera>();
        myCamera.fieldOfView = 60;
    }

    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                myCamera.fieldOfView += zoomHizi;
            }
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                myCamera.fieldOfView -= zoomHizi;
            }
            myCamera.fieldOfView = Mathf.Clamp(myCamera.fieldOfView, fovMin, fovMax);
        
    }
}