using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerPrefs.SetInt("highscore", scoretracker.highScore);
        PlayerPrefs.Save();
        SceneManager.LoadScene(0);
    }
}
