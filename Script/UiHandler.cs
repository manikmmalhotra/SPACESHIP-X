using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiHandler : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitBTn()
    {
        Application.Quit();
    }

    public void menubtn()
    {
        SceneManager.LoadScene(0);
    }
}
