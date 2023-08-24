using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Slider slider;
    public GameObject player;
    private NavMeshAgent _agent;
    private Transform _target;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _target = player.transform;
    }

    void Update()
    {
        _agent.SetDestination(_target.position);

        if ((player.transform.position - _agent.transform.position).sqrMagnitude < 10)
        {
            slider.value -= 10 * Time.deltaTime;
        }
    }
}
