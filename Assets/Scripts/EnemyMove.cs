using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor;

public class EnemyMove : MonoBehaviour
{
    private Vector3 _target;
    NavMeshAgent agent;
    
    
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
       
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
    private void Update()
    {
        SetTargetPosition();
        SetAgentPosition();
       
       
    }
    void SetTargetPosition()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
    void SetAgentPosition()
    {
        agent.SetDestination(new Vector3(_target.x, _target.y, transform.position.z));
    }
}
