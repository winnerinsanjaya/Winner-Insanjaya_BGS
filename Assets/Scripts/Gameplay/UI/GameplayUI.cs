using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using PlayFab;

namespace BGS.UI
{
    public class GameplayUI : MonoBehaviour
    {

        [SerializeField]
        private GameObject pauseMenu;

        

        public void OnPause()
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }

        public void OnResume()
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
    }

        public void LogOut()
        {
            Time.timeScale = 1;
            PlayFabClientAPI.ForgetAllCredentials();
            SceneManager.LoadScene("LoginPage");
        }
    }
}
