using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject dayObject;
    public GameObject nightObject;
    public GameObject sun;
    private bool nightObjectBool;
    private bool dayObjectBool;

    public float coolDown = 2;
    private float coolDownTimer;
    
    void Start()
    {
        nightObjectBool = true;
        dayObjectBool = false;
        sun.SetActive(false);
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
            sun.SetActive(true);
            InputDetectionLeftShift();
            InputDetectionRightShift();
        }
    }
    

   void InputDetectionLeftShift()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            

            Debug.Log("Left Shift");
            //GO TO NIGHT
            if(dayObjectBool == true )
            {
                dayObjectBool = false;
                nightObjectBool = true;
                dayObject.SetActive(false);
                nightObject.SetActive(true);
                sun.SetActive(false);
                coolDownTimer = coolDown;
            }
            //GO TO DAY
            else if (dayObjectBool == false)
            {
                dayObjectBool = true;
                nightObjectBool = false;
                dayObject.SetActive(true);
                nightObject.SetActive(false);
                //canvas.SetActive(true);
            }  
        }

    }

    void InputDetectionRightShift()
    {
       
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            

            Debug.Log("Right Shift");
            if (dayObjectBool == true )
            {
                dayObjectBool = false;
                nightObjectBool = true;
                dayObject.SetActive(false);
                nightObject.SetActive(true);
                coolDownTimer = coolDown;
                sun.SetActive(false);
            }
            else if(dayObjectBool == false)
            {
                dayObjectBool = true;
                nightObjectBool = false;
                dayObject.SetActive(true);
                nightObject.SetActive(false);
              //  canvas.SetActive(true);
            }
        }
    }
    
}
