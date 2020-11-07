using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMotion : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent theAgent;

    public bool IsWalking;
    private Animation _animation;

    // Start is called before the first frame update
    void Start()
    {
        _animation = GetComponent<Animation>();
        theAgent = GetComponent<NavMeshAgent>();
        theAgent.SetDestination(target.transform.position);
        IsWalking = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsWalking)
            _animation.Play("BasicMotions@Walk01");
        else
        {
            _animation.Play("BasicMotions@Idle01");
        }
    }
}
