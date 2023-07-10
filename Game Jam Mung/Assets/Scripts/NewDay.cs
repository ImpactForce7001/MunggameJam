using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewDay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (JerryAi.timeUp)
        {
            PlayerObjectInteraction.teeth = true;
            PlayerObjectInteraction.eat = true;
            PlayerObjectInteraction.wash = true;
            PlayerObjectInteraction.reading = true;
            SceneManager.LoadScene(2);
            JerryAi.timeUp = false;
        }
    }
}
