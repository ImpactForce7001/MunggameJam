using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    public GameObject move;
    public GameObject interact;
    public GameObject openPhone;
    public GameObject viewTasks;
    public GameObject jerry;
    public GameObject pause;
    public GameObject door;

    bool h;
    bool d;
    bool e;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D)&&!d || Input.GetKeyDown(KeyCode.A)&&!d)
        {
            d = true;
            move.SetActive(false);
            interact.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E)&&!e)
        {
            e = true;
            interact.SetActive(false);
            openPhone.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.F)&&h)
        {
            viewTasks.SetActive(false);
            door.GetComponent<TaskObjectInteraction>().enabled = true;
            door.GetComponent<BoxCollider2D>().enabled = true;
            pause.SetActive(true);
            jerry.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.F)&&!h)
        {
            h = true;
            openPhone.SetActive(false);
            viewTasks.SetActive(true);
        }
    }
}
