using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.Movement
{
    public class Mover : MonoBehaviour
    {
        private NavMeshAgent playerNavMeshAgent;
        private Animator characterAnimation;

        void Start()
        {
            playerNavMeshAgent = GetComponent<NavMeshAgent>();
            characterAnimation = GetComponent<Animator>();
        }

        void Update()
        {
            UpdateAnimator();
        }

        public void MoveTo(Vector3 destination)
        {
            playerNavMeshAgent.SetDestination(destination);
        }

        void UpdateAnimator()
        {
            Vector3 velocity = playerNavMeshAgent.velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity);

            float speed = localVelocity.z;

            characterAnimation.SetFloat("forwardSpeed", speed);
        }
    }
}
