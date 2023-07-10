using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
                else if (xyz.gameObject.tag == "LaundryInteractionZone" && wash) //If the player begins washing game
                {
                    PlayerPoints += 1;
                    Debug.Log(PlayerPoints);
                    wash = false;
                }
                else if (xyz.gameObject.tag == "FridgeInteractionZone" && eat) //If the player begins eating game
                {
                    PlayerPoints += 1;
                    Debug.Log(PlayerPoints);
                    eat = false;
                }
                else if (xyz.gameObject.tag == "ReadingInteractionZone" && excercise) //If the player begins Reading game
                {
                    PlayerPoints += 1;
                    Debug.Log(PlayerPoints);
                    excercise = false;
                }
                else if (xyz.gameObject.tag == "LoungeDoor") //If the player begins toothbrush game
                {
                    Debug.Log(PlayerPoints);
                    SceneManager.LoadScene(4);
                }
                else if (xyz.gameObject.tag == "BathroomDoor") //If the player begins toothbrush game
                {
                    Debug.Log(PlayerPoints);
                    SceneManager.LoadScene(1);
                }
                else if (xyz.gameObject.tag == "KitchenDoor") //If the player begins toothbrush game
                {
                    Debug.Log(PlayerPoints);
                    SceneManager.LoadScene(2);
                }
                else if (xyz.gameObject.tag == "BedroomDoor") //If the player begins toothbrush game
                {
                    Debug.Log(PlayerPoints);
                    SceneManager.LoadScene(3);
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
