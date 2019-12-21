using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bg : MonoBehaviour 
{

    public float r = 0;
    public float g = 0;
    public float b = 0;


    void Update()
    {
        r += Time.deltaTime * 0.1f;
        g += Time.deltaTime * 0.1f;
        b += Time.deltaTime * 0.1f;

        if (r >= 1.0f)
        {
            r = 0.0f; 
        }
        if (g >= 1.0f)
        {
           g = 0.0f;
        }
        if (b >= 1.0f)
        {
            b = 0.0f;
        }

        GetComponent<Image>().color = new Color(r, g, b, 0.5f);

        //this.GetComponent<Camera>().clearFlags = CameraClearFlags.Color;
        //this.GetComponent<Camera>().backgroundColor = new Color(r, g, b, 0.5f);
    }
}
