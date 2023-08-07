using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
using UnityEngine.Events;

using BGS.Shop;

public class PlayfabManager : MonoBehaviour
{
    [Header("UI")]

    [SerializeField]
    private string nextScene;

    public static UnityAction OnLogin;

    #region Login
    [SerializeField]
    private GameObject loginPage;
    [SerializeField]
    private Text messageText;
    [SerializeField]
    private InputField usernameLogin;
    [SerializeField]
    private InputField passwordLogin;
    #endregion

    #region Register
    [SerializeField]
    private GameObject RegisPage;
    [SerializeField]
    private InputField usernameRegister;
    [SerializeField]
    private InputField nicknameRegister;
    [SerializeField]
    private InputField passwordRegister;
    [SerializeField]
    private InputField reasswordRegister;
    #endregion

    [SerializeField]
    private GameObject RecoveryPage;
    [SerializeField]
    private InputField usernameRecovery;

    private void Start()
    {
        SetLoginState();
    }




    #region pagestate
    private enum PageState
    {
        Login,
        Regis,
        Recovery
    }

    private PageState currentState;

    public void SetLoginState()
    {
        currentState = PageState.Login;
        CheckCurrentState();
    }

    public void SetRegisState()
    {
        currentState = PageState.Regis;
        CheckCurrentState();
    }

    public void SetRecoveryState()
    {
        currentState = PageState.Recovery;
        CheckCurrentState();
    }

    private void CheckCurrentState()
    {
        switch (currentState)
        {
            case PageState.Login:
                loginPage.SetActive(true);
                RegisPage.SetActive(false);
                RecoveryPage.SetActive(false);
                break;
            case PageState.Regis:
                loginPage.SetActive(false);
                RegisPage.SetActive(true);
                RecoveryPage.SetActive(false);
                break;
            case PageState.Recovery:
                loginPage.SetActive(false);
                RegisPage.SetActive(false);
                RecoveryPage.SetActive(true);
                break;
        }
    }
    #endregion



    public void RegisterUser()
    {
        var request = new RegisterPlayFabUserRequest
        {
            DisplayName = nicknameRegister.text,
            Username = nicknameRegister.text,
            Email = usernameRegister.text,
            Password = passwordRegister.text,
            RequireBothUsernameAndEmail = false
        };

        if (passwordRegister.text != reasswordRegister.text)
        {
            StartCoroutine(OnError("Password didnt Match!"));
            return;
        }

        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnRegisterError);
    }
    private void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        StartCoroutine(OnSuccess("Create Account Successfully!"));
        StartCoroutine(OnRegisterSuccess());
    }

    private void OnRegisterError(PlayFabError error)
    {
        string message = error.ErrorMessage;
        StartCoroutine(OnError(message));
    }


    IEnumerator OnRegisterSuccess()
    {
        yield return new WaitForSeconds(1f);
        SetLoginState();
    }

    public void LoginUser()
    {
        if (usernameLogin.text.IndexOf('@') > 0)
        {
            var request = new LoginWithEmailAddressRequest
            {
                Email = usernameLogin.text,
                Password = passwordLogin.text,

                InfoRequestParameters = new GetPlayerCombinedInfoRequestParams()
                {
                    GetPlayerProfile = true,
                }
            };

            PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnLoginError);
        }

        if (usernameLogin.text.IndexOf('@') <= 0)
        {
            var request = new LoginWithPlayFabRequest
            {
                Username = usernameLogin.text,
                Password = passwordLogin.text,

                InfoRequestParameters = new GetPlayerCombinedInfoRequestParams()
                {
                    GetPlayerProfile = true,
                }
            };

            PlayFabClientAPI.LoginWithPlayFab(request, OnLoginSuccess, OnLoginError);
        }
    }


    private void OnLoginError(PlayFabError error)
    {
        string message = error.ErrorMessage;

        StartCoroutine(OnError(message));
    }

    private void OnLoginSuccess(LoginResult result)
    {
        string email = result.SessionTicket;
        PlayfabDatabase.instance.playfabId = result.PlayFabId;
        OnLogin?.Invoke();
        StartCoroutine(OnLoginSuccess_Coroutine());
        StartCoroutine(OnSuccess("Loggin In!"));
    }

    IEnumerator OnLoginSuccess_Coroutine()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(nextScene);
    }

    public void ResetPasswordButton()
    {
        var request = new SendAccountRecoveryEmailRequest
        {
            Email = usernameRecovery.text,
            TitleId = "ABD66"
        };
        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnPasswordReset, OnRecoveryError);
    }

    private void OnPasswordReset(SendAccountRecoveryEmailResult result)
    {
        StartCoroutine(OnSuccess("Password Reset Request Sent!"));
    }

    private void OnRecoveryError(PlayFabError error)
    {
        string message = error.ErrorMessage;

        StartCoroutine(OnError(message));
    }


    IEnumerator OnSuccess(string message)
    {
        messageText.text = message;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitForSeconds(1.5f);
        messageText.text = "";
    }

    IEnumerator OnError(string message)
    {
        messageText.text = message;
        yield return new WaitForSeconds(0.2f);
        yield return new WaitForSeconds(2f);
        messageText.text = "";
    }

    public void WithoutLogin()
    {
        StartCoroutine(OnLoginSuccess_Coroutine());
        StartCoroutine(OnSuccess("Loggin In!"));
    }
}
