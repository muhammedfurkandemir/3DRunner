using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Opponent : MonoBehaviour
{
    public NavMeshAgent OpponentAgent;
    public GameObject Target;
    void Start()
    {
        OpponentAgent = GetComponent<NavMeshAgent>();

    }

    
    void Update()
    {
        OpponentAgent.SetDestination(Target.transform.position);
    }
}
