using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    private NavMeshAgent playerNavMeshAgent;

    void Start()
    {
        playerNavMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MoveToCursor();
        }
    }


    void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        bool isHit = Physics.Raycast(ray, out hit);

        if(isHit)
        {
            playerNavMeshAgent.SetDestination(hit.point);
        }
    }
}
