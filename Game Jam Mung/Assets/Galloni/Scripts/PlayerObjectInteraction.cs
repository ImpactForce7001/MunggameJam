using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(collision.gameObject.tag);
            if (collision.gameObject.tag == "ToothbrushInteractionZone") //If the player begins toothbrush game
            {
                //Toothbrush actions i.e. activate minigame
            }
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {

    }
}
