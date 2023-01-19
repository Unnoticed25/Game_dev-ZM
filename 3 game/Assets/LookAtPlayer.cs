using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public GameObject healthbar;
    public GameObject enemy;
    public Transform camera;
    private EnemyScript takedamagefrom;

    public void Start()
    {
        takedamagefrom = enemy.GetComponent<EnemyScript>();
    }
   
    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(camera);
    }

    // void Update() {
    //     if (takedamagefrom.TakeDamage()) {
    //     healthbar.SetActive(true);
    //     }
    // }

}
