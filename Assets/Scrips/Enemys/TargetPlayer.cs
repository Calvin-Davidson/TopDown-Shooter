using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class TargetPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private NavMeshAgent agent;
    private Transform _player;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        _player = GameObject.Find("Player").GetComponent<Transform>();
        agent.Warp(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 loc = _player.position;
        agent.SetDestination(loc);
    }
}
