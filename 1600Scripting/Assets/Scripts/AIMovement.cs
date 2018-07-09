using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIMovement : MonoBehaviour
{
	private NavMeshAgent Agent;
	
	private void Start ()
	{
		Agent = GetComponent<NavMeshAgent>();
	}
	
	private void Update () {
		Agent.destination = Vector3.zero;
	}
}
