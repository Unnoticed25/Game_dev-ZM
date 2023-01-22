using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
   public void Play () {
    SceneManager.LoadScene("SampleScene");
   }

   public void Quit () {
    Application.Quit();
    Debug.Log("Game closed");
   }
}
