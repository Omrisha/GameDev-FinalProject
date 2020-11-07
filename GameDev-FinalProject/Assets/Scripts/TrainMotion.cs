using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TrainMotion : MonoBehaviour
{
    public NPCObjectScript Object1;
    public NPCObjectScript Object2;
    public NPCObjectScript Object3;
    public NPCObjectScript Object4;
    
    public GameObject Wheels;
    public Animator WheelsAnimator;

    public GameObject targetA;
    public GameObject targetB;
    NavMeshAgent theAgent;
    // Start is called before the first frame update
    void Start()
    {
        WheelsAnimator = Wheels.GetComponent<Animator>();
        theAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Object1.npcArrived && Object2.npcArrived && Object3.npcArrived & Object4.npcArrived)
        {
            theAgent.SetDestination(targetB.transform.position);
            WheelsAnimator.SetTrigger("Start");
        }

        if (transform.position == targetB.transform.position)
        {
            transform.position = targetA.transform.position;
        }
    }
}
