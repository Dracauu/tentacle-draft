using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleBarrageBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
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
        if (GetComponent<Transform>().position.x >= -6)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3(-250, 0, 0), ForceMode2D.Force);
        }

        if (GetComponent<Transform>().position.x < -20)
        {

            GameObject.FindGameObjectWithTag("ObstaclesManager").GetComponent<LayingObstacles>().SetTentaclePresence(GameObject.FindGameObjectWithTag("ObstaclesManager").GetComponent<LayingObstacles>().GetTentaclePresence() - 1);
            Destroy(gameObject);
        }
    }
}
