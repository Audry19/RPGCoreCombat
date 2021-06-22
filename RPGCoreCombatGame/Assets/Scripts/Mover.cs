using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    private NavMeshAgent playerNavMeshAgent;

    [SerializeField] private Transform targetTransform;

    void Start()
    {
        playerNavMeshAgent = GetComponent<NavMeshAgent>();

        playerNavMeshAgent.SetDestination(targetTransform.position);
    }

    void Update()
    {
        if(playerNavMeshAgent.remainingDistance > 0)
        {
            playerNavMeshAgent.SetDestination(targetTransform.position);
        }
        
    }
}
