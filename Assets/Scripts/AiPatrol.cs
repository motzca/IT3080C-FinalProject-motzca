using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiPatrol : MonoBehaviour
{
    public Transform[] waypoints;
    private int currentWPTarget = 0;
    private NavMeshAgent agent;
   
    private bool playerDetected;
    public float detectionDistance = 20f;
    public float detectionRadius = 2f;
    private RaycastHit raycastHitInfo;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        if(!agent.pathPending && agent.remainingDistance < 0.5f){
            goToNextPoint();
        }
        else{
            CheckIfPlayerInLos();
        }
    }

    private void goToNextPoint(){
        if(waypoints.Length == 0){
            return;
        }

        agent.destination = waypoints[currentWPTarget].position;
        currentWPTarget = (currentWPTarget + 1) % waypoints.Length;
    }

    private void CheckIfPlayerInLos(){
        playerDetected = Physics.SphereCast(transform.position, detectionRadius, transform.forward, out raycastHitInfo, detectionDistance);
        if(playerDetected){
            if(raycastHitInfo.transform.CompareTag("Player")){
                Debug.Log("Hey! I see you!");
                agent.destination = raycastHitInfo.transform.position;
            }
        }
    }
}
