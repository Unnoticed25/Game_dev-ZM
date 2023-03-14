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
    
    // Привязываение объектов оружия переменным
    private GameObject PistolReal;

    // Привязываение объектов Фейк-оружия переменным
    private GameObject PistolFake;

    //Поиск по имени объекта предметов, которые можно взять
    public void RealObjects(){
        PistolReal = GameObject.Find("Pistol92White");
        PistolReal.SetActive(false);
    }
    //Поиск по имени объекта Фейк-предметов
    public void FakesObjects(){
        PistolFake = GameObject.Find("Pistol92fake");
    }
    
    void Awake()
    {
        FakesObjects();
        RealObjects();
    }

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
                currentWeapon.transform.localPosition = new Vector3(-0.3f, 0f, 0f);
                currentWeapon.transform.localEulerAngles = new Vector3(-8f, -104f, 65f);
                canPickUp = true;
                PickUped = true;
            }

            if(hit.transform.tag == "Pistol")
            {
                if (canPickUp) Drop();
                PistolReal.SetActive(true);
                Destroy(PistolFake);
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