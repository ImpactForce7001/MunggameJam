using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BurgerMinigame : MonoBehaviour
{
    public Button plate;
    public Button bottomBun;
    public Button patty;
    public Button tomato;
    public Button lettce;
    public Button sauce;
    public Button topBun;

    public Button burgerExample;

    public List<Button> ingredients;

    public bool inMinigame = false;

    public int currentItem;



    // Start is called before the first frame update
    void Start()
    {
        ingredients.Add(plate);
        ingredients.Add(bottomBun);
        ingredients.Add(patty);
        ingredients.Add(tomato);
        ingredients.Add(lettce);
        ingredients.Add(sauce);
        ingredients.Add(topBun);

        //shuffle
        for (int i = 0; i < 100; i++)
        {
            int item1 = Random.Range(0, ingredients.Count);
            int item2 = Random.Range(0, ingredients.Count);
            Button temp = ingredients[item1];
            ingredients[item1] = ingredients[item2];
            ingredients[item2] = temp;
        }

        for (int i = 0; i < ingredients.Count; i++)
        {
            Button temp = ingredients[i];
            temp.gameObject.transform.position = new Vector2((135 + (250 * i)), 900f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(!inMinigame)
        {
            plate.gameObject.SetActive(false);
            bottomBun.gameObject.SetActive(false);
            patty.gameObject.SetActive(false);
            tomato.gameObject.SetActive(false);
            lettce.gameObject.SetActive(false);
            sauce.gameObject.SetActive(false);
            topBun.gameObject.SetActive(false);
            burgerExample.gameObject.SetActive(false);
        }
        else
        {
            plate.gameObject.SetActive(true);
            bottomBun.gameObject.SetActive(true);
            patty.gameObject.SetActive(true);
            tomato.gameObject.SetActive(true);
            lettce.gameObject.SetActive(true);
            sauce.gameObject.SetActive(true);
            topBun.gameObject.SetActive(true);
            burgerExample.gameObject.SetActive(true);
        }
    }

    public void StartBurgerGame()
    {
        inMinigame = true;
        PlayerMovement.inGame = true;
        currentItem = 0;
    }

    public void Plate()
    {
        if (currentItem == 0)
        {
            plate.gameObject.transform.position = new Vector2(1287, 200 + 25 * currentItem);
            currentItem++;
        }
    }

    public void BottomBun()
    {
        if (currentItem == 1)
        {
            bottomBun.gameObject.transform.position = new Vector2(1287, 200 + 25 * currentItem);
            currentItem++;
        }
    }

    public void Patty()
    {
        if (currentItem == 2)
        {
            patty.gameObject.transform.position = new Vector2(1287, 200 + 25 * currentItem);
            currentItem++;
        }
    }

    public void Tomato()
    {
        if (currentItem == 3)
        {
            tomato.gameObject.transform.position = new Vector2(1287, 200 + 25 * currentItem);
            currentItem++;
        }
    }

    public void Lettuce()
    {
        if (currentItem == 4)
        {
            lettce.gameObject.transform.position = new Vector2(1287, 200 + 25 * currentItem);
            currentItem++;
        }
    }

    public void Sauce()
    {
        if (currentItem == 5)
        {
            sauce.gameObject.transform.position = new Vector2(1287, 200 + 25 * currentItem);
            currentItem++;
        }
    }

    public void TopBun()
    {
        if (currentItem == 6)
        {
            if(transform.parent.gameObject.tag == "StoveInteractionZone")
            {
                PhoneController.strikeJFood = true;
            }
            else
            {
                PhoneController.strikeFood = true;
            }

            topBun.gameObject.transform.position = new Vector2(1287, 200 + 25 * currentItem);
            PlayerObjectInteraction.PlayerPoints += 1;
            inMinigame = false;
            PlayerMovement.inGame = false;
        }
    }
}
