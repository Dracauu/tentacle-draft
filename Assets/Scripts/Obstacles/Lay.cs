using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lay : MonoBehaviour
{
    public GameObject[] elements;

    private int startb1;
    private int startb2;
    private int startb3;
    private int startb4;
    private int tentacleID;

    // Start is called before the first frame update
    void Start()
    {
        startb1 = Random.Range(-4, 5);
        startb2 = Random.Range(-4, 5);
        while(startb2 == startb1)
        {
            startb2 = Random.Range(-4, 5);
        }

        startb3 = Random.Range(-4, 5);
        while (startb3 == startb1 || startb3 == startb2)
        {
            startb3 = Random.Range(-4, 5);
        }

        startb4 = Random.Range(-4, 4);
        while (startb4 == startb1 || startb4 == startb2 || startb4 == startb3)
        {
            startb4 = Random.Range(-4, 5);
        }

        if (GameObject.FindWithTag("ScoreManager").GetComponent<ScoreUpdating>().GetScore() >= 500)
        {
            tentacleID = Random.Range(1, 3);
        }
        else {
            tentacleID = 1;
        }

        GameObject BlockA1 = Instantiate(elements[0], new Vector3(13, startb1, -1), Quaternion.identity);
        BlockA1.GetComponent<BlockBehaviour>().GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0), ForceMode2D.Force);

        GameObject BlockA2 = Instantiate(elements[0], new Vector3(13, startb2, -1), Quaternion.identity);
        BlockA2.GetComponent<BlockBehaviour>().GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0), ForceMode2D.Force);

        GameObject BlockA3 = Instantiate(elements[0], new Vector3(13, startb3, -1), Quaternion.identity);
        BlockA3.GetComponent<BlockBehaviour>().GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0), ForceMode2D.Force);

        GameObject BlockA4 = Instantiate(elements[0], new Vector3(13, startb4, -1), Quaternion.identity);
        BlockA4.GetComponent<BlockBehaviour>().GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0), ForceMode2D.Force);

        if (Random.Range(0, 3) >= 1 && GameObject.FindGameObjectWithTag("ObstaclesManager").GetComponent<LayingObstacles>().GetTentaclePresence() <= GameObject.FindWithTag("ObstaclesManager").GetComponent<LayingObstacles>().GetTentacleLimit()) {
            GameObject.FindGameObjectWithTag("ObstaclesManager").GetComponent<LayingObstacles>().SetTentaclePresence(GameObject.FindGameObjectWithTag("ObstaclesManager").GetComponent<LayingObstacles>().GetTentaclePresence() + 1);
            Debug.Log(GameObject.FindGameObjectWithTag("ObstaclesManager").GetComponent<LayingObstacles>().GetTentaclePresence());
            GameObject TentacleA1 = Instantiate(elements[tentacleID], new Vector3(-20, Random.Range(-3, 3), -2), Quaternion.identity);
            int speed;
            if(tentacleID == 1)
            {
                speed = 100;
            }
            else
            {
                speed = 30;
            }
            TentacleA1.GetComponent<Rigidbody2D>().AddForce(new Vector3(speed, 0, 0), ForceMode2D.Force);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject);
    }
}
