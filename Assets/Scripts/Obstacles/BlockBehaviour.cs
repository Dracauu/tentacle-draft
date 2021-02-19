using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockBehaviour : MonoBehaviour
{

     private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreUpdating>().Setlockscore(true);
            GameObject.FindGameObjectWithTag("GameOverText").GetComponent<TMPro.TextMeshProUGUI>().text = "You lost !\n Your score is :\n" + GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreUpdating>().GetScore() + "\n\nPress Space to\ntry again";
            if (GameObject.FindGameObjectWithTag("Text"))
            {
                GameObject.FindGameObjectWithTag("Text").SetActive(false);
            }
            GameObject.FindWithTag("ScoreManager").GetComponent<ScoreUpdating>().gameover = true;
            Time.timeScale = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.GetComponent<Transform>().position.x <= -20)
        {
            Destroy(this.gameObject);
        }
    }
}