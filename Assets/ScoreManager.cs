using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;
    public GameObject Menu;
    private float score = 0;
    private float highscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + (int)score;
        highscoreText.text = "Highscore: " + (int)highscore;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("s=" + (int)score + " ; hs=" + (int)highscore);
        if (Menu.activeSelf)
        {
            // highscoreText.text = "Highscore: " + ((score > highscore) ? (int)highscore : (int)score);
            if (score > highscore)
            {
                highscoreText.text = "Highscore: " + (int)score;
                highscore = score;
            }
            
            score = 0;
        }
        else
        {
            scoreText.text = "Score: " + (int)score;
            score += Time.deltaTime;
        }
    }
}
