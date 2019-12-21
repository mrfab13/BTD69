using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class play : MonoBehaviour
{
    public void smashplay()
    {
        SceneManager.LoadScene(1);
    }

    public void dontsmashplay()
    {
        Application.Quit();
    }

}
