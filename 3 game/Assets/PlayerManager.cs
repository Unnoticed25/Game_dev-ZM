using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static int playerHP;
    public static bool isGameOver;
    public TextMeshProUGUI playerHPText;
    public GameObject bloodOverlay;

    void Start()
    {
        isGameOver = false;
        playerHP = 100;
    }

    // Update is called once per frame
    void Update()
    {
        playerHPText.text = "" + playerHP;
        if (isGameOver)
        {
            SceneManager.LoadScene("EnemyDamage");
        }
    }
            

    public IEnumerator Damage (int damageAmount)
    {
        bloodOverlay.SetActive(true);
        playerHP -= damageAmount;
        if (playerHP <= 0)
            isGameOver = true;

        yield return new WaitForSeconds(1f);
        bloodOverlay.SetActive(false);
    }
}
