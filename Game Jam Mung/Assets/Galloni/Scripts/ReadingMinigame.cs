using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReadingMinigame : MonoBehaviour
{
    public GameObject leftSideSample;
    public GameObject rightSideSample;
    public GameObject leftSideInput;
    public GameObject rightSideInput;

    private TextMeshProUGUI leftSideSampleTMP;
    private TextMeshProUGUI rightSideSampleTMP;
    private TextMeshProUGUI leftSideInputTMP;
    private TextMeshProUGUI rightSideInputTMP;

    private string phraseLeft;
    private string phraseRight;
    private string phraseLeftInput;
    private string phraseRightInput;

    private int whichText;

    // Start is called before the first frame update
    void Start()
    {
        leftSideSampleTMP = leftSideSample.GetComponent<TextMeshProUGUI>();
        rightSideSampleTMP = rightSideSample.GetComponent<TextMeshProUGUI>();
        leftSideInputTMP = leftSideInput.GetComponent<TextMeshProUGUI>();
        rightSideInputTMP = rightSideInput.GetComponent<TextMeshProUGUI>();

        int randomPhrase = Random.Range(0, 5);

        if (randomPhrase >= 0)
        {
            phraseLeft = "its joever";
            phraseRight = "we're barack";
        }

        leftSideSampleTMP.text = phraseLeft;
        rightSideSampleTMP.text = phraseRight;

        phraseLeftInput = "";
        phraseRightInput = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(whichText == 1)
        {
            if(Input.inputString == "\b")
            {
                if (phraseLeftInput.Length > 0)
                {
                    phraseLeftInput = phraseLeftInput.Substring(0, phraseLeftInput.Length - 1);
                }
            }
            if(Input.inputString != "\n" && Input.inputString != "\r")
            {
                phraseLeftInput += Input.inputString;
            }
        }
        else if(whichText == 2)
        {
            if (Input.inputString == "\b")
            {
                if (phraseRightInput.Length > 0)
                {
                    phraseRightInput = phraseRightInput.Substring(0, phraseRightInput.Length - 1);
                }
            }
            if (Input.inputString != "\n" && Input.inputString != "\r")
            {
                phraseRightInput += Input.inputString;
            }
        }

        Debug.Log(whichText);
        Debug.Log(phraseLeftInput);
        Debug.Log(phraseRightInput);

        if (phraseLeftInput == phraseLeft && phraseRightInput == phraseRight)
        {
            Debug.Log("This shit tweaking");
            transform.gameObject.SetActive(false);
        }
    }

    public void SwitchTexts(int text)
    {
        whichText = text;
    }
}
