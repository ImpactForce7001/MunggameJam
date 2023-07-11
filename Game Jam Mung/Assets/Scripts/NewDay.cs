using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewDay : MonoBehaviour
{
    public static int days = 0;
    public static bool JerryWin = false;
    public static bool PlayerWin = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (JerryAi.timeUp)
        {
            
        }
    }
    public static void FinishDay()
    {
        PlayerObjectInteraction.teeth = true;
        PlayerObjectInteraction.eat = true;
        PlayerObjectInteraction.wash = true;
        PlayerObjectInteraction.reading = true;
        SceneManager.LoadScene(3);
        GameManager.timeElapsed = 0;
        days += 1;
        if(days >= 4)
        {
            //load end scene
            if(PlayerObjectInteraction.PlayerPoints == 16)
            {
                PlayerWin = true;
            }
            if(PlayerObjectInteraction.JerryPoints == 16)
            {
                JerryWin = true;
            }
        }
    }
}
