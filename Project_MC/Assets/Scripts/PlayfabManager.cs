using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
//using NewtonSoft.Json;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
//using System.Diagnostics;

public class PlayfabManager : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI messageText;

    public TMP_InputField emailInput;
    public TMP_InputField passwordInput;

    public void RegisterButton()
    {
        if(passwordInput.text.Length < 6)
        {
            messageText.text = "Password too short!";
            return;
        }
        var request = new RegisterPlayFabUserRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
    }

    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        messageText.text = "Registered and logged in!";
        Invoke("Delay", 2f);
    }

    void Delay()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoginButton()
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text
        };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnError);
    }

    public void OnLoginSuccess(LoginResult result)
    {
        messageText.text = "Logged in!";
        Debug.Log("Successful login/account create");
        Invoke("Delay", 2f);
    }

    public void ResetPasswordButton()
    {
        var request = new SendAccountRecoveryEmailRequest
        {
            Email = emailInput.text,
            TitleId = "DCCF8"
        };
        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnPasswordReset, OnError);
    }

    public void OnPasswordReset(SendAccountRecoveryEmailResult result)
    {
        messageText.text = "Password reset email sent!";
    }

    void OnError(PlayFabError error)
    {
        messageText.text = error.ErrorMessage;
        Debug.Log(error.GenerateErrorReport());
    }

    // Start is called before the first frame update
    /*void Start()
    {
        Login();
    }

    void Login()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);
    }

    void OnSuccess(LoginResult result)
    {
        Debug.Log("Successful login/account create");
    }

    void OnError(PlayFabError error)
    {
        Debug.Log("Error in login/creating account");
        Debug.Log(error.GenerateErrorReport());
    }*/
}
