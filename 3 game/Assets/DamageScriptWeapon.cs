using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScriptWeapon : MonoBehaviour
{
    public int damageAmount = 25;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Enemy"){
            other.GetComponent<EnemyScript>().TakeDamage(damageAmount);
        }
        
    }
   
}
