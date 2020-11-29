using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.AI;

public class TrainMotion : MonoBehaviour
{
    public GameObject Wheels;
    public Animator WheelsAnimator;
    public Rigidbody rigidBody;
    
    public GameObject targetA;
    public GameObject targetB;
    NavMeshAgent theAgent;
    // Start is called before the first frame update
    void Start()
    {
        WheelsAnimator = Wheels.GetComponent<Animator>();
        theAgent = GetComponent<NavMeshAgent>();
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CounterScript.numberOfPeople == 4)
        {
            theAgent.SetDestination(targetB.transform.position);
            WheelsAnimator.SetTrigger("Start");
        }

        if (Vector3.Distance(rigidBody.position, targetB.transform.position).CompareTo(0) == 0)
        {
            if (CounterScript.numberOfPeople == 0)
                theAgent.SetDestination(targetA.transform.position);
        }
    }
}
