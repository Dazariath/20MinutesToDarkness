using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
   
    public Transform respawnPoint;
    
   

     void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Respawn");
            other.transform.position = respawnPoint.position;
        }


    }
}
