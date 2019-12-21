using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{

    public float health = 100.0f;
    void Update()
    {
        gameObject.transform.localPosition += new Vector3(Time.deltaTime * 0.5f, 0.0f, 0.0f);

        if (health <= 0.0f)
        {
            GameObject.Find("UItext").GetComponent<Text>().text = "youer a winner";
            GameObject.Find("manager").GetComponent<manager>().count = 0;
            Destroy(this.gameObject);
        }
    }
}
