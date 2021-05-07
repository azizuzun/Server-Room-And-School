using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuLook : MonoBehaviour
{
    
  

    [SerializeField] private float mouseSensitivity =30;

    [SerializeField] private Transform playerBody;
    /*xAxisClamp ile Kısıtlama koyuyoruz*/
    private float xAxisClamp;
    
    private void Awake()
    {
        Cursor.visible = false;
        LockCursor();
        xAxisClamp = 0.0f;
    }

    /*İmleç Kilitleme*/
    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        CameraRotation();
        
    }
    /*Kameranın Dönüşü*/
    private void CameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        if (xAxisClamp > 90.0f)
        {
            xAxisClamp = 90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(270.0f);
        }
        else if (xAxisClamp < -25.0f)
        {
            xAxisClamp = -25.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(20.0f);
        }

        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void ClampXAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }

}