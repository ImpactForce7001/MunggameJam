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
        PlayerObjectInteraction.JerryTeeth = true;
        PlayerObjectInteraction.JerryEat = true;
        PlayerObjectInteraction.JerryWash = true;
        PlayerObjectInteraction.JerryReading = true;
        SceneManager.LoadScene(3);
        timeElapsed = 0;
        days += 1;
        if (days >= 4)
        {
            //load end scene
            if (PlayerObjectInteraction.PlayerPoints == 16)
            {
                PlayerWin = true;
            }
            if (PlayerObjectInteraction.JerryPoints == 16)
            {
                JerryWin = true;
            }
        }
        if (PlayerWin)
        {
            if (JerryWin)
            {
                //print text saying jerry won, and player won.
            }
            else
            {
                //print text saying player won, but Jerry lost
            }
        }
        else
        {
            if (JerryWin)
            {
                //print text saying player lost, but Jerry won
            }
            else
            {
                //print text saying both player and jerry lost.
            }
        }
    }

}