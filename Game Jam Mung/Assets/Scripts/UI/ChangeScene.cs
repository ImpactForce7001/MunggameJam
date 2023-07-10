using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(4);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
