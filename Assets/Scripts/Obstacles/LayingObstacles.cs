using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LayingObstacles : MonoBehaviour
{

    public GameObject[] layoutList;
    private int cooldown = 240;
    private int time = 0;
    private int tentaclepresence = 0;

    private int tentaclelimit = 0; //+1

    public int GetTentacleLimit()
    {
        return tentaclelimit;
    }

    public void SetTentacleLimit(int newt)
    {
        tentaclelimit = newt;
    }

    public int GetTentaclePresence()
    {
        return tentaclepresence;
    }

    public void SetTentaclePresence(int tentaclenumber)
    {
        tentaclepresence = tentaclenumber;
    }

    // Start is called before the first frame update
    void Start()
    {
        //UnityEngine.Random.InitState(Convert.ToInt32(System.DateTime.Now));
        GameObject clone = Instantiate(layoutList[0]);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("ScoreManager").GetComponent<ScoreUpdating>().GetScore() > 4000)
        {
            cooldown = 55;
            tentaclelimit = 3;
        }
        else
        if (GameObject.FindWithTag("ScoreManager").GetComponent<ScoreUpdating>().GetScore() > 2500)
        {
            cooldown = 60;
            tentaclelimit = 2;
        } else
        if (GameObject.FindWithTag("ScoreManager").GetComponent<ScoreUpdating>().GetScore() > 2000)
        {
            cooldown = 75;
        }
        else
        if (GameObject.FindWithTag("ScoreManager").GetComponent<ScoreUpdating>().GetScore() > 1500)
        {
            cooldown = 100;
        }
        else
        if (GameObject.FindWithTag("ScoreManager").GetComponent<ScoreUpdating>().GetScore() > 1000)
        {
            cooldown = 125;
        }
        else
        if (GameObject.FindWithTag("ScoreManager").GetComponent<ScoreUpdating>().GetScore() > 750)
        {
            cooldown = 150;
            tentaclelimit = 1;
        }
        else
        if (GameObject.FindWithTag("ScoreManager").GetComponent<ScoreUpdating>().GetScore() > 500)
        {
            cooldown = 160;
        }
        else if (GameObject.FindWithTag("ScoreManager").GetComponent<ScoreUpdating>().GetScore() > 300)
        {
            cooldown = 180;
        } else if (GameObject.FindWithTag("ScoreManager").GetComponent<ScoreUpdating>().GetScore() > 150)
        {
            cooldown = 200;
        } else if (GameObject.FindWithTag("ScoreManager").GetComponent<ScoreUpdating>().GetScore() > 75)
        {
            cooldown = 220;
        }

        if(Time.timeScale == 1)
        {
            time++;
            if (time >= cooldown)
            {
            Instantiate(layoutList[0]);
            time = 0;
            }
        }

        
    }
}
