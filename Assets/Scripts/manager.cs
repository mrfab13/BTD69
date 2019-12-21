using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class manager : MonoBehaviour
{
    public float count = 1;
    public float timer = 5.0f;
    void Update()
    {

        if (count == 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0.0f)
            {
                SceneManager.LoadScene(0);

            }

        }
    }
}
