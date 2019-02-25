using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterController : MonoBehaviour
{
    public float followRadius = 10f;
    Transform player;
    NavMeshAgent agent;
    

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = PlayerManager.instance.player.transform;

    }

    private void Update()
    {
      // float distance = Vector3.Distance(player.position, transform.position);

        
       agent.SetDestination(player.position); 
        
    }

    // Update is called once per frame
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, followRadius);
    }
}
