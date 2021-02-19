using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera cam = this.GetComponent<Camera>();
        Debug.Log("width = " + cam.pixelWidth + " height = " + cam.pixelHeight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
