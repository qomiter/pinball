using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoretracker : MonoBehaviour
{
    public static int gameScore;
    public static int highScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameScore = 0;
        highScore = PlayerPrefs.GetInt("highscore", highScore);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameScore > highScore)
        {
            highScore = gameScore;
        }
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 200, 20), "Score: " + gameScore.ToString());
        GUI.Box(new Rect(20, 40, 200, 20), "High Score: " + highScore.ToString());
    }
}
