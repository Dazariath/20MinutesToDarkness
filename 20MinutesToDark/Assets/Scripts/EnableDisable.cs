using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject dayObject;
    public GameObject nightObject;
    private bool nightObjectBool;
    private bool dayObjectBool;

    public float coolDown = 2;
    private float coolDownTimer;
    
    void Start()
    {
        nightObjectBool = true;
        dayObjectBool = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (coolDownTimer >= 0)
        {
            coolDownTimer -= Time.deltaTime;
        }

        if(coolDownTimer < 0 )
        {
            coolDownTimer = 0;
        }

        if(coolDownTimer == 0)
        {
            InputDetectionLeftShift();
            InputDetectionRightShift();
            
        }
    }
    

   void InputDetectionLeftShift()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            coolDownTimer = coolDown;

            Debug.Log("Left Shift");
            if(dayObjectBool == true )
            {
                dayObjectBool = false;
                nightObjectBool = true;
                dayObject.SetActive(false);
                nightObject.SetActive(true);
            }
            else if (dayObjectBool == false)
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
            coolDownTimer = coolDown;

            Debug.Log("Right Shift");
            if (dayObjectBool == true )
            {
                dayObjectBool = false;
                nightObjectBool = true;
                dayObject.SetActive(false);
                nightObject.SetActive(true);
            }
            else if(dayObjectBool == false)
            {
                dayObjectBool = true;
                nightObjectBool = false;
                dayObject.SetActive(true);
                nightObject.SetActive(false);
            }
        }
    }
    
}
