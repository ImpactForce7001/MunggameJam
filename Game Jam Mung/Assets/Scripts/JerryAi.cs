using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JerryAi : MonoBehaviour
{

    public static bool timeUp = false;
    public static float JerryX = 0;
    public static float JerryY = -2f;
    public static int JerryScene = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if( currentTask == laundry)
            {
            go to bedroom
            go to wardrobe
            put on clothes
            if (clean){
            JerryPoints += 1
            }
        else{
        jerry Points -= 1;
        }

            }
        */
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(JerryScene))
        {

        }
        else
        {
            JerryY = 5f;
        }
    }
}
