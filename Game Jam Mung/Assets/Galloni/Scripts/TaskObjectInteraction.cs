using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskObjectInteraction : MonoBehaviour
{

    public GameObject interactMsg; //The popup message to interact i.e. 'Press [E] to interact'
    public TMPro.TextMeshProUGUI textMeshPro;
    public string tooltip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactMsg.SetActive(true);
            textMeshPro.text = tooltip;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactMsg.SetActive(false);
            textMeshPro.text = "";
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("abc");
            }
        }
    }
}
