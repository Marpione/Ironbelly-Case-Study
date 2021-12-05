using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMotor : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    NavMeshAgent NavMeshAgent { get { return (navMeshAgent == null) ? navMeshAgent = GetComponent<NavMeshAgent>() : navMeshAgent; } }

    public float Speed;


    public void Move(Vector3 direction)
    {
        direction = Camera.main.transform.TransformDirection(direction);
        NavMeshAgent.Move(direction * Time.deltaTime * Speed);
    }
}
