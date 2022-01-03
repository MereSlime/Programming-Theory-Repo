using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public TMP_InputField inputField;
    public static string username;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OnEntry()
    {
        username = inputField.GetComponent<TMP_InputField>().text;
        MainManager.instance.username = username;
        Debug.Log(username);
    }
}
