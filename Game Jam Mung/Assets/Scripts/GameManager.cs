using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static bool justStarted = true;
    public static float timeElapsed;
    public int timeRounded;
    public int timeLimit = 60;
    public int timeLeftInSeconds;
    public int timeLeftInMinutes;
    public string timeDisplayString;
    public Text timeDisplayText;
    public TextMeshProUGUI finalText;

    public static int days = 0;
    public static bool JerryWin = false;
    public static bool PlayerWin = false;

    void Start()
    {
        Debug.Log("Loaded New Scene");
        if(justStarted)
        {
            Debug.Log("Timer Reset");
            timeElapsed = 0;
            justStarted = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        timeRounded = Mathf.FloorToInt(timeElapsed);

        timeLeftInSeconds = (timeLimit - timeRounded) % 60;
        timeLeftInMinutes = ((timeLimit - timeRounded)/60) % 60;

        if (!(timeRounded >= timeLimit))
        {
            string leadingZeroSeconds = "";
            if (timeLeftInSeconds < 10)
                leadingZeroSeconds = "0";

            timeDisplayString = timeLeftInMinutes + ":" + leadingZeroSeconds + timeLeftInSeconds;
            timeDisplayText.text = timeDisplayString;
        }
        else
        {
            Debug.Log("Day End");
            timeDisplayText.text = "0:00";
            FinishDay();
            //SceneManager.LoadScene(0);

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(6))
        {
            if (PlayerWin)
            {
                if (JerryWin)
                {
                    finalText.text = "Jerry won, and you won! \n CONGRATULATIONS!";
                }
                else
                {
                    finalText.text = "Jerry lost, but you won! \n congratulations?";
                }
            }
            else
            {
                if (JerryWin)
                {
                    finalText.text = "Jerry won, and you lost! \n congratulations?";
                }
                else
                {
                    finalText.text = "Jerry lost, and you lost \n bad luck!";
                }
            }
        }
       
    }

    public void AllowTimerReset()
    {
        justStarted = true;
    }
    public void FinishDay()
    {
        PlayerObjectInteraction.teeth = true;
        PlayerObjectInteraction.eat = true;
        PlayerObjectInteraction.wash = true;
        PlayerObjectInteraction.reading = true;
        PlayerObjectInteraction.JerryEat = true;
        PlayerObjectInteraction.JerryWash = true;
        
        timeElapsed = 0;
        days += 1;
        if (days >= 4)
        {
            //load end scene
            if (PlayerObjectInteraction.PlayerPoints == 16)
            {
                PlayerWin = true;
            }
            if (PlayerObjectInteraction.JerryPoints == 8)
            {
                JerryWin = true;
            }
            SceneManager.LoadScene(6);
        }
        SceneManager.LoadScene(3);

    }

}