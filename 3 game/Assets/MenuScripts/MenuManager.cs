using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

   [SerializeField] private GameObject _mainCamera;
   [SerializeField] private GameObject _settingsCamera;
   [SerializeField] private GameObject _menuPanel;
   [SerializeField] private GameObject _menuSettings;
   public void Play () {
      SceneManager.LoadScene("SampleScene");
   }

   public void Quit () {
      Application.Quit();
      Debug.Log("Game closed");
   }

   public void Settings () {
      _mainCamera.SetActive(false);
      _menuPanel.SetActive(false);
      _settingsCamera.SetActive(true);
      _menuSettings.SetActive(true);
   }

   public void Back () {
      _settingsCamera.SetActive(false);
      _menuSettings.SetActive(false);
      _mainCamera.SetActive(true);
      _menuPanel.SetActive(true);
      
   }
}
