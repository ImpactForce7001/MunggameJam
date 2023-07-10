using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectInteraction : MonoBehaviour
{
    public static int JerryPoints = 0;
    public bool abc = false;
    public static int PlayerPoints = 0;
    private Collider2D xyz;
    public static bool teeth = true;
    public static bool eat = true;
    public static bool wash = true;
    public static bool excercise = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (abc)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                if (xyz.gameObject.tag == "ToothbrushInteractionZone" && teeth) //If the player begins toothbrush game
                {
                    PlayerPoints += 1;
                    Debug.Log(PlayerPoints);
                    teeth = false;
                }
                if (xyz.gameObject.tag == "LaundryInteractionZone" && wash) //If the player begins toothbrush game
                {
                    PlayerPoints += 1;
                    Debug.Log(PlayerPoints);
                    wash = false;
                }
                if (xyz.gameObject.tag == "FridgeInteractionZone" && eat) //If the player begins toothbrush game
                {
                    PlayerPoints += 1;
                    Debug.Log(PlayerPoints);
                    eat = false;
                }
                if (xyz.gameObject.tag == "ExcerciseInteractionZone" && excercise) //If the player begins toothbrush game
                {
                    PlayerPoints += 1;
                    Debug.Log(PlayerPoints);
                    excercise = false;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        abc = true;
        xyz = collision;
    }
   
    private void OnTriggerExit2D(Collider2D collision)
    {
        abc = false;
    }
}
