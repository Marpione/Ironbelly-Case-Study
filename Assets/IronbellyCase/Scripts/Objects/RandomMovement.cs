using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomMovement : MonoBehaviour
{
    NavMeshSurface navMeshSurface;
    NavMeshSurface NavMeshSurface { get { return (navMeshSurface == null) ? navMeshSurface = FindObjectOfType<NavMeshSurface>() : navMeshSurface; } }

    NavMeshAgent navMeshAgent;
    NavMeshAgent NavMeshAgent { get { return (navMeshAgent == null) ? navMeshAgent = GetComponent<NavMeshAgent>() : navMeshAgent; } }

    private void Start()
    {
        SetDestination();
    }

    private void SetDestination()
    {
        NavMeshAgent.SetDestination(NavMeshSurface.GetRandomPositionMovementArea());
    }

    private void Update()
    {
        if(Vector3.Distance(transform.position, NavMeshAgent.destination) < 1f)
        {
            SetDestination();
        }
    }
}
