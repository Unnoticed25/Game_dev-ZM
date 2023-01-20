using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{   
    private int HP = 100;
    public Animator animator;
    public Slider healthBar;

    
    
    void start()
    {
        healthBar.value = HP;
        healthBar.gameObject.SetActive(false);
    }

    void Update()
    {
        healthBar.value = HP;
    }
    

    public void TakeDamage (int damageAmount) {
        HP -= damageAmount;
        healthBar.gameObject.SetActive(true);
        
        if(HP <= 0){
            animator.SetTrigger("death");
            GetComponent<Collider>().enabled = false;
            // DamageItem.gameObject.SetActive(false);
            healthBar.gameObject.SetActive(false);
        }
        else{
            animator.SetTrigger("damage");
        }
        StartCoroutine(WaittohideHp());
         
    }

    


    private IEnumerator WaittohideHp(){
        healthBar.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        healthBar.gameObject.SetActive(false);
    }
}

