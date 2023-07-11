using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PhoneController : MonoBehaviour
{
    public GameObject strikeBookObj;
    public GameObject strikeFoodObj;
    public GameObject strikeTeethObj;
    public GameObject strikeLaundryObj;
    public GameObject strikeJLaundryObj;
    public GameObject strikeJFoodObj;
    public static bool strikeBook = false;
    public static bool strikeFood = false;
    public static bool strikeTeeth = false;
    public static bool strikeLaundry = false;
    public static bool strikeJLaundry = false;
    public static bool strikeJFood = false;
    private bool showPhone = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            showPhone = !showPhone;
            transform.GetChild(0).gameObject.SetActive(showPhone);
        }
        if (strikeBook)
        {
            strikeBookObj.GetComponent<TextMeshProUGUI>().text = "<s>" + strikeBookObj.GetComponent<TextMeshProUGUI>().text + "</s>";
        }
        if (strikeFood)
        {
            strikeFoodObj.GetComponent<TextMeshProUGUI>().text = "<s>" + strikeFoodObj.GetComponent<TextMeshProUGUI>().text + "</s>";
        }
        if (strikeTeeth)
        {
            strikeTeethObj.GetComponent<TextMeshProUGUI>().text = "<s>" + strikeTeethObj.GetComponent<TextMeshProUGUI>().text + "</s>";
        }
        if (strikeLaundry)
        {
            strikeLaundryObj.GetComponent<TextMeshProUGUI>().text = "<s>" + strikeLaundryObj.GetComponent<TextMeshProUGUI>().text + "</s>";
        }
        if (strikeJLaundry)
        {
            strikeJLaundryObj.GetComponent<TextMeshProUGUI>().text = "<s>" + strikeJLaundryObj.GetComponent<TextMeshProUGUI>().text + "</s>";
        }
        if (strikeJFood)
        {
            strikeJFoodObj.GetComponent<TextMeshProUGUI>().text = "<s>" + strikeJFoodObj.GetComponent<TextMeshProUGUI>().text + "</s>";
        }
    }
}
