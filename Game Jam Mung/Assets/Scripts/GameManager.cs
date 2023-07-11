using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hi");
        if(justStarted)
        {
            Debug.Log("Reset");
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
        }
    }
}