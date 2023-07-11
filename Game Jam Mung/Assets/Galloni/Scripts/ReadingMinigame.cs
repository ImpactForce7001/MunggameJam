using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReadingMinigame : MonoBehaviour
{
    public GameObject leftSideSample;
    public GameObject rightSideSample;
    public GameObject rightSideInput;

    private TextMeshProUGUI leftSideSampleTMP;
    private TextMeshProUGUI rightSideSampleTMP;

    private string phraseLeft;
    private string phraseRight;
    private string phraseRightInput;

    private int whichText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement.inGame = true;
        leftSideSampleTMP = leftSideSample.GetComponent<TextMeshProUGUI>();
        rightSideSampleTMP = rightSideSample.GetComponent<TextMeshProUGUI>();

        phraseLeft = "The black cat sat on the shaggy carpet.\r\nThe black cat is sitting on the shaggy carpet.\r\nWhat a silly black cat, to sit on the shaggy carpet.";
        phraseRight = "The black cat has never before sat on the shaggy carpet.\r\nThe black cat will never again sit on the shaggy carpet.";
        leftSideSampleTMP.text = phraseLeft;
        rightSideSampleTMP.text = phraseRight;
        phraseRight = "The black cat has never before sat on the shaggy carpet.The black cat will never again sit on the shaggy carpet.";

        phraseRightInput = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(whichText == 2)
        {
            if (Input.inputString == "\b")
            {
                if (phraseRightInput.Length > 0)
                {
                    phraseRightInput = phraseRightInput.Substring(0, phraseRightInput.Length - 1);
                }
            }
            else if(Input.inputString != "\r" && Input.inputString != "\n")
            {
                phraseRightInput += Input.inputString;
            }
        }

        if (phraseRightInput == phraseRight)
        {

            PhoneController.strikeBook = true;
            PlayerMovement.inGame = false;
            PlayerObjectInteraction.PlayerPoints += 1;
            transform.gameObject.SetActive(false);
        }
    }

    public void SwitchTexts(int text)
    {
        whichText = text;
    }
}
