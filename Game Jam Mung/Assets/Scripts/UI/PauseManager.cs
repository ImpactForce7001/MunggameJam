using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public bool paused = false;
    public Button ResumeButton;
    public Button ExitButton;
    public Text PauseTitle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = true;
            Time.timeScale = 0;
        }

        if (!paused)
        {
            ResumeButton.gameObject.SetActive(false);
            ExitButton.gameObject.SetActive(false);
            PauseTitle.gameObject.SetActive(false);
        }
        else
        {
            ResumeButton.gameObject.SetActive(true);
            ExitButton.gameObject.SetActive(true);
            PauseTitle.gameObject.SetActive(true);
        }
    }

    public void UnPause()
    {
        paused = false;
        Time.timeScale = 1;
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("TitleScreen");
    }


}
