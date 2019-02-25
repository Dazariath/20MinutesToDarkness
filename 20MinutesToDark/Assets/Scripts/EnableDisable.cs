using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject dayObject;
    public GameObject nightObject;
    private bool nightObjectBool;
    private bool dayObjectBool;
    
    void Start()
    {
        nightObjectBool = true;
        dayObjectBool = false;
    }

    // Update is called once per frame
    void Update()
    {
        InputDetectionLeftShift();
        InputDetectionRightShift();

    }

    void InputDetectionLeftShift()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("Left Shift");
            if(dayObjectBool == true)
            {
                dayObjectBool = false;
                nightObjectBool = true;
                dayObject.SetActive(false);
                nightObject.SetActive(true);
            }
            else 
            {
                dayObjectBool = true;
                nightObjectBool = false;
                dayObject.SetActive(true);
                nightObject.SetActive(false);
            }  
        }

    }

    void InputDetectionRightShift()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Debug.Log("Right Shift");
            if (dayObjectBool == true)
            {
                dayObjectBool = false;
                nightObjectBool = true;
                dayObject.SetActive(false);
                nightObject.SetActive(true);
            }
            else
            {
                dayObjectBool = true;
                nightObjectBool = false;
                dayObject.SetActive(true);
                nightObject.SetActive(false);
            }
        }
    }
}
