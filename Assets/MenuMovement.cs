using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuMovement : MonoBehaviour
{
    private bool onScreen = false;
    private bool started = false;

    private Vector3 startPos;
    private Vector3 endPos;
    public Vector3 offset;

    public float speed;
    private float startTime;
    private float journyLength;

    private int currentMenu = 0;

    GameObject animationBox;
    GameObject cameraBox;


    
    void Start()
    {
        //setting up variables for a lerp 
        startPos = gameObject.transform.position;
        endPos = startPos + offset;

        journyLength = Vector3.Distance(startPos, endPos);

    }

    
    void Update()
    {
        if (started)
        {
            if (onScreen)
            {
                float distanceCoverd = (Time.time - startTime) * speed;
                float fracJourney = distanceCoverd / journyLength;

                transform.position = Vector3.Lerp(startPos, endPos, fracJourney);
            }
            else
            {
                float distanceCoverd = (Time.time - startTime) * speed;
                float fracJourney = distanceCoverd / journyLength;

                transform.position = Vector3.Lerp(endPos, startPos, fracJourney);
            }
        }
    }

    public void StartMovement(int newMenu)
    {
        // Checks to see if the menu selected is the on currently shown 
        if (newMenu != currentMenu && onScreen)
        {
            currentMenu = newMenu;
        }
        else
        {
            started = true;
            if (onScreen)
            {
                onScreen = false;
            }
            else
            {
                onScreen = true;

            }
            //resets the time that the lerps started making it go back to the starting position
            startTime = Time.time;
        }
    }
    public void ChangeActiveMenu(GameObject menu)
    {
        // sets the indicated menu to be drawn last making it be the one that is shown on screen 
        menu.transform.SetAsLastSibling();
    }
}
