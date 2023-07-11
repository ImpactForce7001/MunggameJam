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
    public static bool eatJerry = true;
    public static bool wash = true;
    public static bool reading = true;
    public static bool JerryTeeth = true;
    public static bool JerryEat = true;
    public static bool JerryWash = true;
    public static bool JerryReading = true;
    public GameObject teethObject;




    //all the laundry code is here
    public static bool JerryNeedsLaundry = false;
    public GameObject JerryClothes;
    public static bool HaveJerryClothes = false;
    public static bool JerryClothesClean = false;
    public static bool HavePlayerClothes = false;
    public static bool PlayerClothesClean = false;
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
                    PlayerMovement.inGame = true;
                }
                else if (xyz.gameObject.tag == "LaundryInteractionZone" && (wash || JerryWash)) //If the player begins washing game
                {
                    if (HavePlayerClothes && HaveJerryClothes && !JerryClothesClean)
                    {
                        StartCoroutine(washJerryClothes());
                    }
                    else if (HaveJerryClothes && !JerryClothesClean)
                    {
                        StartCoroutine(washJerryClothes());
                    }
                    else if (!HaveJerryClothes && JerryClothesClean)
                    {
                        HaveJerryClothes = true;
                    }
                    else if (HavePlayerClothes && !PlayerClothesClean)
                    {
                        StartCoroutine(washPlayerClothes());
                    }
                    else if (!HavePlayerClothes && PlayerClothesClean)
                    {
                        HavePlayerClothes = true;
                    }

                }
                else if (xyz.gameObject.tag == "JerryDirtyClothes" && wash) //If the player begins washing game
                {
                    if (JerryClothesClean)
                    {
                        JerryPoints += 1;
                        JerryWash = false;
                        Debug.Log("Jerry laundry done");
                    }

                    else
                    {
                        HaveJerryClothes = true;
                    }

                }
                else if (xyz.gameObject.tag == "PlayerDirtyClothes" && wash) //If the player begins washing game
                {
                    if (PlayerClothesClean)
                    {
                        PlayerPoints += 1;
                        wash = false;
                        Debug.Log("player laundry done");
                    }
                    HavePlayerClothes = true;
                }
                else if (xyz.gameObject.tag == "FridgeinteractionZone" && eat) //If the player begins eating game
                {
                    xyz.gameObject.transform.GetChild(1).gameObject.GetComponent<BurgerMinigame>().StartBurgerGame();
                    eat = false;
                }
                else if (xyz.gameObject.tag == "StoveinteractionZone" && eatJerry) //If the player begins eating game
                {
                    xyz.gameObject.transform.GetChild(1).gameObject.GetComponent<BurgerMinigame>().StartBurgerGame();
                    eatJerry = false;
                }
                else if (xyz.gameObject.tag == "ReadingInteractionZone") //If the player begins Reading game
                {
                    xyz.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    reading = false;
                }
                else if(xyz.gameObject.tag == "PhoneInteractionZone")
                {
                    xyz.gameObject.SetActive(false);
                }
                else if (xyz.gameObject.tag == "LoungeDoor") //If the player begins toothbrush game
                {

                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
                    {
                        PlayerMovement.xPosition = 6.8f;
                        PlayerMovement.yPosition = -2.18f;
                    }
                    else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2))
                    {
                        PlayerMovement.xPosition = -2.85f;
                        PlayerMovement.yPosition = -2.18f;
                    }
                    else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3)|| SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5))
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
    public IEnumerator washJerryClothes()
    {
        HaveJerryClothes = false;
        yield return new WaitForSeconds(10);
        JerryClothesClean = true;
        Debug.Log("Jerry laundry finished");
    }
    public IEnumerator washPlayerClothes()
    {
        HavePlayerClothes = false;

        yield return new WaitForSeconds(10);

        PlayerClothesClean = true;
        Debug.Log("Player laundry finished");
    }
}