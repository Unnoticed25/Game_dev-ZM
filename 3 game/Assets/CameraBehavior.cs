using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    [SerializeField] private float Sensitivity;
    private float xAngle;
    private float yAngle;
    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        yAngle += Input.GetAxis("Mouse X") * Sensitivity;
        xAngle -= Input.GetAxis("Mouse Y") * Sensitivity;
        transform.rotation = Quaternion.Euler(xAngle, yAngle, 0);
    }
}