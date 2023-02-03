using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWeapon : MonoBehaviour
{

    public GameObject camera;
    public float distance = 15f;
    GameObject currentWeapon;
    bool canPickUp = false;
    bool PickUped = false;
    public AudioSource audio;
    public AudioClip pressaudio;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) PickUp();
        if (Input.GetKeyDown(KeyCode.G)) Drop();

        if (PickUped == true)
        {
            if (Input.GetButtonDown("Fire1")){
            GetComponent<AudioSource>().PlayOneShot(pressaudio);
            }
        }
    }

    public void PickUp()
    {
        RaycastHit hit;
        if(Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, distance))
        {
            if(hit.transform.tag == "Weapon")
            {
                if (canPickUp) Drop();

                currentWeapon = hit.transform.gameObject;
                currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
                currentWeapon.GetComponent<Collider>().isTrigger = true;
                currentWeapon.transform.parent = transform;
                currentWeapon.transform.localPosition = Vector3.zero;
                currentWeapon.transform.localEulerAngles = new Vector3(-8f, -104f, 65f);
                canPickUp = true;
                PickUped = true;
            }

            if(hit.transform.tag == "Pistol")
            {
                if (canPickUp) Drop();

                currentWeapon = hit.transform.gameObject;
                currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
                currentWeapon.GetComponent<Collider>().isTrigger = true;
                currentWeapon.transform.parent = transform;
                currentWeapon.transform.localPosition = new Vector3(-0f, 0.07615261f, -0.03805602f);
                currentWeapon.transform.localEulerAngles = new Vector3(0f, -84f, 0f);
                canPickUp = true;
                PickUped = true;
            }
        }
    }



    void Drop()
    {
        currentWeapon.transform.parent = null;
        currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
        currentWeapon.GetComponent<Collider>().isTrigger = false;
        canPickUp = false;
        currentWeapon = null;
        PickUped = false;
    }
}