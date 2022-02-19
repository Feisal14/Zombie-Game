using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform target;
    public float chaseRange = 5f;
    
    NavMeshAgent navMechAgent;
    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;
    void Start()
    {
        navMechAgent = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        // how far away is the target..
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        

        // if our the distance to target is less than the range move
        if(distanceToTarget <= chaseRange)
        {
            navMechAgent.SetDestination(target.position);
        }
        
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

}
