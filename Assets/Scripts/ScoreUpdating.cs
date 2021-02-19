using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Globalization;
using UnityEngine.SceneManagement;

public class ScoreUpdating : MonoBehaviour
{

    private int scoreiterator = 0;
    private double time = 0;
    private int score = 0;
    private bool lockedscore = false;
    public bool gameover = false;

    public double GetScore()
    {
        return score;
    }
    public void Setlockscore(bool lockscore)
    {
        lockedscore = lockscore;
    }

    private TMPro.TextMeshProUGUI textobject;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Time.timeScale = 0;
        textobject = GameObject.FindWithTag("Text").GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && Time.timeScale == 0)
        {
            if (gameover == true)
            {
                SceneManager.LoadScene("SampleScene");
            }
            else
            {
                GameObject.FindGameObjectWithTag("StartText").SetActive(false);
                Time.timeScale = 1;
            }
        }

        if (!lockedscore && Time.timeScale == 1)
        {
            time++;
            scoreiterator++;
            if (scoreiterator >= 75)
            {
                scoreiterator = 0;
                score += Convert.ToInt32(Math.Log(50 * time));
                textobject.text = score.ToString();
            }
        }
    }
}
