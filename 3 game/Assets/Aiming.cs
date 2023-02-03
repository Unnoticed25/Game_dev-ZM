using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
    public Camera mainCamera;
    public Camera aimCamera;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            mainCamera.enabled = false;
            aimCamera.enabled = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            mainCamera.enabled = true;
            aimCamera.enabled = false;
        }
    }
}
