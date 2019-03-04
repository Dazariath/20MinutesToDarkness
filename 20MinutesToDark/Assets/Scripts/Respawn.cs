using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public Transform respawnPoint;
   // public Transform monsterSpawn;
    public GameObject player;
    //public GameObject monster;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Respawn");
           // monster.transform.position = monsterSpawn.transform.position;
            player.transform.position = respawnPoint.transform.position;
        }
    }
    
}

