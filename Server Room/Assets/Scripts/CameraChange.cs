using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Camera cam01;
    public Camera cam02;
    public Camera cam03;

    private void Start()
    {
        cam01.enabled = false;
        cam02.enabled = true;
        cam03.enabled = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            

            cam01.enabled = !cam01.enabled;
            cam02.enabled = !cam02.enabled;

        }
        /*if (Input.GetKeyDown("m"))
        {

            cam02.enabled = !cam02.enabled;

            cam03.enabled = !cam03.enabled;

        }*/
        


    }

    

}
