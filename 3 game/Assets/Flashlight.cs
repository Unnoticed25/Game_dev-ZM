using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private Light Flashl;
    public AudioSource audio;
    public AudioClip pressaudio;
    
    void Start()
    {
        Flashl = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Flashl.enabled = !Flashl.enabled;
            audio.PlayOneShot(pressaudio);
        }
           
    }



}