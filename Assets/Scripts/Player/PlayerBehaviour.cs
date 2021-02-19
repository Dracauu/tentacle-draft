using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody2D playerbody;
    Transform playertransform;


    // Start is called before the first frame update
    void Start()
    {
        playertransform = gameObject.GetComponent<Transform>();
        playerbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playertransform.Translate(new Vector3(0, 4) * Time.deltaTime, Space.World);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            playertransform.Translate(new Vector3(0, -4) * Time.deltaTime, Space.World);
        }    
    }
}
