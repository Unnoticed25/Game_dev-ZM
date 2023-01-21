using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

    // public AudioClip[] runningAudio;
    private Light Flashl;
    private bool FlashlightOn;
    private AudioSource audioturn;
    void Start()
    {
        Flashl = GetComponent<Light>();
        audioturn = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Flashl.enabled = !Flashl.enabled;
            FlashlightOn = true;
        }
        FlashlightOn = false;
    }


    void FixedUpdate(){
        if(FlashlightOn == true){
           audioturn.enabled = !audioturn.enabled;
        }
    }

}