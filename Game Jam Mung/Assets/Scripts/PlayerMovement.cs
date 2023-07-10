using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector3(5,5,5);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector3(-5, 5, 5);
        }
        if (horizontalInput == 0)
        {
            animator.Play("Idle");
        }
        else if (horizontalInput != 0)
        {
            animator.Play("Walk");
        }
        


        transform.position = transform.position + new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0, 0);
    }
}
