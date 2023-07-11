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
    public static bool reading = true;
    public GameObject teethObject;
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
                    teethminigame.teethStart = true;
                    teethObject.SetActive(true);
                }
                else if (xyz.gameObject.tag == "LaundryInteractionZone" && wash) //If the player begins washing game
                {
                    PlayerPoints += 1;
                    Debug.Log(PlayerPoints);
                    wash = false;
                }
                else if (xyz.gameObject.tag == "FridgeinteractionZone" && eat) //If the player begins eating game
                {
                    xyz.gameObject.transform.GetChild(1).gameObject.GetComponent<BurgerMinigame>().StartBurgerGame();
                    eat = false;
                }
                else if (xyz.gameObject.tag == "ReadingInteractionZone") //If the player begins Reading game
                {
                    xyz.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                }
                else if (xyz.gameObject.tag == "LoungeDoor") //If the player begins toothbrush game
                {
                    
                    if(SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
                    {
                        PlayerMovement.xPosition = 6.8f;
                        PlayerMovement.yPosition = -2.18f;
                    }
                    else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2))
                    {
                        PlayerMovement.xPosition = -2.85f;
                        PlayerMovement.yPosition = -2.18f;
                    }
                    else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3))
                    {
                        PlayerMovement.xPosition = -8f;
                        PlayerMovement.yPosition = -2.18f;
                    }
                    Debug.Log(PlayerPoints);
                    SceneManager.LoadScene(4);
                }
                else if (xyz.gameObject.tag == "BathroomDoor") //If the player begins toothbrush game
                {
                    
                    PlayerMovement.xPosition = -6.5f;
                    PlayerMovement.yPosition = -1.78f;
                    
                    Debug.Log(PlayerPoints);
                    SceneManager.LoadScene(1);
                }
                else if (xyz.gameObject.tag == "KitchenDoor") //If the player begins toothbrush game
                {
                    PlayerMovement.xPosition = 7f;
                    PlayerMovement.yPosition = -1.78f;
                    Debug.Log(PlayerPoints);
                    SceneManager.LoadScene(2);
                }
                else if (xyz.gameObject.tag == "BedroomDoor") //If the player begins toothbrush game
                {
                    PlayerMovement.xPosition = 7.7f;
                    PlayerMovement.yPosition = -2.13f;
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
