using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.days = 0;
        GameManager.timeElapsed = 0;
        PlayerObjectInteraction.teeth = true;
        PlayerObjectInteraction.eat = true;
        PlayerObjectInteraction.wash = true;
        PlayerObjectInteraction.reading = true;
        PlayerObjectInteraction.JerryEat = true;
        PlayerObjectInteraction.JerryWash = true;
        PhoneController.strikeBook = false;
        PhoneController.strikeFood = false;
        PhoneController.strikeTeeth = false;
        PhoneController.strikeLaundry = false;
        SceneManager.LoadScene(5);
        
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
