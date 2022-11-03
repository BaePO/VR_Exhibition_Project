using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavScript : MonoBehaviour
{
    private NavMeshAgent agent;
    private LineRenderer line;

    public Transform destination;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        line = GetComponent<LineRenderer>();
    }
    private void OnEnable()
    {
        agent.isStopped = true;
        agent.SetDestination(destination.position);
        StartCoroutine(FindPath());
    }

    IEnumerator FindPath()
    {
        yield return new WaitForSeconds(1.0f);
        line.positionCount = agent.path.corners.Length;
        line.SetPositions(agent.path.corners);
        StopAllCoroutines();
    }
}
