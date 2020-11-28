using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMotion : MonoBehaviour
{
    public GameObject target;
    public GameObject targetB;
    public Rigidbody rb;
    public bool isOnTrain = false;
    public bool IsWalking;
    private Animation _animation;

    // Start is called before the first frame update
    void Start()
    {
        _animation = GetComponent<Animation>();
        rb = GetComponent<Rigidbody>();
        // theAgent = GetComponent<NavMeshAgent>();
        // theAgent.SetDestination(target.transform.position);
        IsWalking = true;
        rb.isKinematic = true;
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

    private void FixedUpdate()
    {
        var distance = Vector3.Distance(rb.position, target.transform.position);
        if (distance > 0f)
        {
            Vector3 movePosition = transform.position;
            transform.LookAt(target.transform);
            movePosition.x = Mathf.MoveTowards(rb.position.x, target.transform.position.x, 2f * Time.fixedDeltaTime);
            movePosition.y = Mathf.MoveTowards(rb.position.y, target.transform.position.y, 2f * Time.fixedDeltaTime);
            movePosition.z = Mathf.MoveTowards(rb.position.z, target.transform.position.z, 2f * Time.fixedDeltaTime);
        
            rb.MovePosition(movePosition);
            // transform.LookAt(target.transform);
            // rb.AddRelativeForce(transform.position + Vector3.forward * 5f, ForceMode.Force);
        }
    }
    
    public  void ChangeTarget()
    {
        
        var temp = target;
        target = targetB;
        targetB = temp;
    }
    
    void FollowTargetWithRotation(Transform target, float distanceToStop, float speed)
    {
        if(Vector3.Distance(transform.position, target.position) > distanceToStop)
        {
            transform.LookAt(target);
            rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Force);
        }
    }
}
