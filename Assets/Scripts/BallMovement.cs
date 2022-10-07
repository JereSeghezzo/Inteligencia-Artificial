using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BallMovement : MonoBehaviour
{
  NavMeshAgent agent;
  public Transform destino;
  float cd;
  
    void Start()
    {
      agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
      cd += Time.deltaTime;
      if(cd > 1f)
      {
        LookForTarget();
        cd = 0f;
      }
    }

    void LookForTarget()
    {
      agent.destination = destino.position;
    }
}
