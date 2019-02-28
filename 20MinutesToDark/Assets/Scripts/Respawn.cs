using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public Transform respawnPoint;
    public Transform monsterSpawn;
    public GameObject player;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Respawn");
            other.transform.position = monsterSpawn.transform.position;
            player.transform.position = respawnPoint.transform.position;
        }
    }
    
}

