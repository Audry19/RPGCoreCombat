using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    private NavMeshAgent playerNavMeshAgent;

    [SerializeField]
    private Animator characterAnimation;

    void Start()
    {
        playerNavMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            MoveToCursor();
        }

        UpdateAnimator();
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


    void UpdateAnimator()
    {
        Vector3 velocity = playerNavMeshAgent.velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);

        float speed = localVelocity.z;

        characterAnimation.SetFloat("forwardSpeed", speed);
    }
}
