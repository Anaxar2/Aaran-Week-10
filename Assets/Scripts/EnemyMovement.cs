using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent agent; // reference to the component navmesh agent
    [SerializeField]
    private GameObject player; // variable for a target > game object

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); // handle the component
       
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position); // set destination to target
    }
}
