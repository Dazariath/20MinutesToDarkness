using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
   
    public Transform respawnPoint;
    public GameObject player;
    

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Debug.Log("Respawn");
            RespawnFunction();
        }


    }

    void RespawnFunction()
    {
        player.transform.position = respawnPoint.transform.position;
    }
}
