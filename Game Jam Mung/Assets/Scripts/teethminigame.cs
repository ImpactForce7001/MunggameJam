using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class teethminigame : MonoBehaviour
{
    public static int clicks = 0;
    public static bool teethStart = false;
    public GameObject teethObject;
    public Transform brushTransform;
    public TMPro.TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (teethStart)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                
                teethStart = false;
                teethObject.SetActive(false);
            }
            if (Input.GetMouseButtonDown(0))
            {
                clicks += 1;
                Debug.Log(clicks);
                Debug.Log(clicks % 2);
                textMeshPro.text = "Clicks: \n" + clicks +"/100";
                if(clicks%2 == 0)
                {
                    brushTransform.position += new Vector3 (0,1,0);
                }
                else
                {
                    brushTransform.position -= new Vector3 (0,1,0);
                }
            }
            if (clicks >= 100)
            {
                PhoneController.strikeTeeth = true;
                PlayerObjectInteraction.PlayerPoints += 1;
                clicks = 0;
                Debug.Log(PlayerObjectInteraction.PlayerPoints);
                PlayerObjectInteraction.teeth = false;
                teethObject.SetActive(false);
                teethStart = false;
                PlayerMovement.inGame = false;
            }
        }
    }
    public static void Brushteeth()
    {
        
    }
}
