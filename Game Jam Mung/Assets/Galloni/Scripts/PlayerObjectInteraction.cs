using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectInteraction : MonoBehaviour
{
    public static int JerryPoints = 0;
    public bool abc = false;
    public static int PlayerPoints = 0;
    private Collider2D xyz;
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
                
                if (xyz.gameObject.tag == "ToothbrushInteractionZone") //If the player begins toothbrush game
                {
                    PlayerPoints += 1;
                    Debug.Log(PlayerPoints);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        abc = true;
        xyz = collision;
        Debug.Log(xyz);
    }
   
    private void OnTriggerExit2D(Collider2D collision)
    {
        abc = false;
    }
}
