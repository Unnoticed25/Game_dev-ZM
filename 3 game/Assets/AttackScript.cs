using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")) animator.SetBool("Attack", true);
        else if (Input.GetButtonUp("Fire1")) animator.SetBool("Attack", false);
    }
}
