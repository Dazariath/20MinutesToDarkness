using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject dayObject;
    public GameObject nightObject;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputDetection();

    }

    void InputDetection()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("deactivate");
            dayObject.SetActive(false);
            nightObject.SetActive(true);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            dayObject.SetActive(true);
            nightObject.SetActive(false);
        }
    }
}
