using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TrainMotion : MonoBehaviour
{
    public Animator animator;
    public GameObject target;
    NavMeshAgent theAgent;
    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
        theAgent = GetComponent<NavMeshAgent>();
        theAgent.SetDestination(target.transform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        //animator.Play("Start");
    }
}
