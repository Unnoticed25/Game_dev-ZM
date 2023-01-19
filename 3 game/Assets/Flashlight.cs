using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private Light Flashl;
    void Start()
    {
        Flashl = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Flashl.enabled = !Flashl.enabled;
        }
    }
}