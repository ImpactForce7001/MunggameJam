using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskObjectInteraction : MonoBehaviour
{

    public GameObject interactMsg; //The popup message to interact i.e. 'Press [E] to interact'

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
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactMsg.SetActive(false);
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
