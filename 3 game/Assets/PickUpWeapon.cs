using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWeapon : MonoBehaviour
{

    public GameObject first_person_camera;
    public float distance = 15f;
    GameObject currentWeapon;
    bool canPickUp;
   

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) PickUp();
        if (Input.GetKeyDown(KeyCode.G)) Drop();
    }

    void PickUp()
    {
        RaycastHit hit;
        if(Physics.Raycast(first_person_camera.transform.position, first_person_camera.transform.forward, out hit, distance))
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
    }
}