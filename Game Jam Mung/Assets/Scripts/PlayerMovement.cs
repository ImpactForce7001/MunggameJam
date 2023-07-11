using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    public static float xPosition = -6.8f;
    public static float yPosition = -2.13f;
    public Animator animator;
    public static bool inGame = false;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, -9);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (!inGame)
        {


            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.localScale = new Vector3(5, 5, 5);

            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                transform.localScale = new Vector3(-5, 5, 5);

            }
            if (horizontalInput < 0.10 && horizontalInput > -0.10)
            {
                animator.Play("Idle");
            }
            else
            {
                animator.Play("Walk");
            }
            transform.position = transform.position + new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0, 0);
        }
        else
        {
            animator.Play("Interact");
        }


        
    }
}
