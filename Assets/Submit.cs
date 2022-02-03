using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Submit : MonoBehaviour
{
    public static Submit instance { get; private set; }
    public InputField username;
    public Button submit;
    public Canvas canvas; 

    private void Start()
    {
        instance = this;
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void EnableCanvas()
    {
        Time.timeScale = 0;
        canvas.enabled = true;
    }

    public void CallSaveData()
    {
        StartCoroutine(SaveData());
    }

    IEnumerator SaveData()
    {
        submit.gameObject.GetComponent<Button>().interactable = false;

        WWWForm form = new WWWForm();
        form.AddField("username", username.text);
        form.AddField("score", scoretracker.gameScore);

        UnityWebRequest www = UnityWebRequest.Post("https://qomiter.com/getscores.php", form);
        yield return www.SendWebRequest();
        if(www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Form upload complete!");
        }
    }

}
