﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterRespawn : MonoBehaviour
{

   
    public Transform monsterSpawn;
    
    public GameObject monster;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("MonsterRespawn");

            monster.transform.position = monsterSpawn.transform.position;
        }
    }

}