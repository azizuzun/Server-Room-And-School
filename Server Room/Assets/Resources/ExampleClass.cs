using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var textFile = Resources.Load <TextAsset> ("HiddenOverDraw");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
