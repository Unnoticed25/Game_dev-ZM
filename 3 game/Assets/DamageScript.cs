using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damageCount = 20;

    private void OnCollisionEnter(Collision collision)
    {
         StartCoroutine(FindObjectOfType<PlayerManager>().Damage(damageCount));
    }
}
