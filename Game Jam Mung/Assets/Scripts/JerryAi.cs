using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class JerryAi : MonoBehaviour
{

    public static bool timeUp = false;
    public static float JerryX = 0f;
    public static float JerryY = -2f;
    public static int JerryScene = 4;
    public static bool newScene = false;
    public float DirectionNumber;
    public int MoveDirectionJerry;
    public Animator animator;
    public bool OpenDoor = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(JerryDirection());
        StartCoroutine(DoorCheck());
    }

    // Update is called once per frame
    void Update()
    {
        if (JerryScene == 4)
        {
<<<<<<< HEAD
            if (JerryX < -7.5f)
=======
            if(JerryX < -7.5f)
>>>>>>> bc774d5aaeec1704ca23cc5fc5c5dd221a90d804
            {
                if (!newScene && OpenDoor)
                {
                    JerryScene = 3;
                    JerryX = 7.7f;
                    newScene = true;
                }
<<<<<<< HEAD

            }
            else if (JerryX > -4f && JerryX < -1.5f)
            {
                if (!newScene && OpenDoor)
                {
                    JerryScene = 2;
                    JerryX = 7f;
                    newScene = true;
                }

            }
            else if (JerryX > 5.5f)
            {
                if (!newScene && OpenDoor)
                {
                    JerryScene = 1;
                    JerryX = -6.5f;
                    newScene = true;
                }

            }
            else
            {
                newScene = false;
            }
            if (JerryX <= -8 || JerryX >= 8.5f)
            {
                MoveDirectionJerry *= -1;
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
            }
        }
        else if (JerryScene == 3)
        {
            if (JerryX > 7f)
            {
                if (!newScene && OpenDoor)
                {
                    JerryScene = 4;
                    JerryX = -7.5f;
                    newScene = true;
                }

            }
=======
                
            }
            else if (JerryX > -4f && JerryX < -1.5f)
            {
                if (!newScene && OpenDoor)
                {
                    JerryScene = 2;
                    JerryX = 7f;
                    newScene = true;
                }
                
            }
            else if (JerryX > 5.5f)
            {
                if (!newScene && OpenDoor)
                {
                    JerryScene = 1;
                    JerryX = -6.5f;
                    newScene = true;
                }
                
            }
            else
            {
                newScene = false;
            }
            if(JerryX <= -8 || JerryX >= 8.5f)
            {
                MoveDirectionJerry *= -1;
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
            }
        }
        else if (JerryScene == 3)
        {
            if (JerryX > 7f)
            {
                if (!newScene && OpenDoor)
                {
                    JerryScene = 4;
                    JerryX = -7.5f;
                    newScene = true;
                }
                
            }
>>>>>>> bc774d5aaeec1704ca23cc5fc5c5dd221a90d804
            else
            {
                newScene = false;
            }
            if (JerryX <= -8 || JerryX >= 8.5f)
            {
                MoveDirectionJerry *= -1;
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
            }
        }
        else if (JerryScene == 2)
        {
            if (JerryX > 5.5f)
            {
                if (!newScene && OpenDoor)
                {
                    JerryScene = 4;
                    JerryX = -3f;
                    newScene = true;
                }
<<<<<<< HEAD

=======
                
>>>>>>> bc774d5aaeec1704ca23cc5fc5c5dd221a90d804
            }
            else
            {
                newScene = false;
            }
            if (JerryX <= -8 || JerryX >= 8.5f)
            {
                MoveDirectionJerry *= -1;
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
            }
        }
        else if (JerryScene == 1)
        {
<<<<<<< HEAD
            if (JerryX < 5.5f)
=======
            if (JerryX < 5.5f )
>>>>>>> bc774d5aaeec1704ca23cc5fc5c5dd221a90d804
            {
                if (!newScene && OpenDoor)
                {
                    JerryScene = 4;
                    JerryX = 7f;
                    newScene = true;
                }
<<<<<<< HEAD

=======
                
>>>>>>> bc774d5aaeec1704ca23cc5fc5c5dd221a90d804
            }
            else
            {
                newScene = false;
            }
            if (JerryX <= -8 || JerryX >= 8.5f)
            {
                MoveDirectionJerry *= -1;
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
            }
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(JerryScene))
        {
            JerryY = PlayerMovement.yPosition;
        }
        else
        {
            JerryY = 10f;

        }
        JerryX += MoveDirectionJerry * 5f * Time.deltaTime;
<<<<<<< HEAD
        transform.position = new Vector3(JerryX, JerryY, 0);
=======
        transform.position = new Vector3( JerryX, JerryY, 0);
>>>>>>> bc774d5aaeec1704ca23cc5fc5c5dd221a90d804
        //transform.position = transform.position + new Vector3(MoveDirectionJerry * 5f * Time.deltaTime, 0, 0);
    }
    public IEnumerator JerryDirection()
    {
        while (true)
        {
            DirectionNumber = Random.Range(0, 10);
            if (DirectionNumber > 5)
            {
                MoveDirectionJerry = 0;
                animator.Play("Idle");
            }
            else if (DirectionNumber > 2.5)
            {
                MoveDirectionJerry = 1;
                animator.Play("Walk");
                transform.localScale = new Vector3(-5, 5, 5);
            }
            else
            {
                MoveDirectionJerry = -1;
                animator.Play("Walk");
                transform.localScale = new Vector3(5, 5, 5);
            }
            yield return new WaitForSeconds(Random.Range(3, 5));
        }
<<<<<<< HEAD


=======
        
        
>>>>>>> bc774d5aaeec1704ca23cc5fc5c5dd221a90d804
    }
    public IEnumerator DoorCheck()
    {
        while (true)
        {
            if (Random.Range(0, 10) > 5)
            {
                OpenDoor = true;
            }
            else
            {
                OpenDoor = false;
            }
<<<<<<< HEAD

=======
            
>>>>>>> bc774d5aaeec1704ca23cc5fc5c5dd221a90d804
            yield return new WaitForSeconds(1.5f);
        }


    }
}
