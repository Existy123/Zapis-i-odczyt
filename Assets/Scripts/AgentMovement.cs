using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMovement : MonoBehaviour
{
    
    public NavMeshAgent agent;
    public Animator anim;


    private bool canMove = true;
   
    void Update()
    {
        anim.SetBool("isMoving", agent.hasPath);
    }
  
    public void MoveToPoint(Vector3 pos)
    {
        if (canMove)
        {
            agent.SetDestination(pos);
        }
    }
    public void SetPosition(Vector3 pos)
    {
        agent.Warp(pos);
    }
    public void StopMoving()
    {
        agent.isStopped = true;
        agent.ResetPath(); 
    }
    public void Die()
    {
        canMove = false;
    }
}
