using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class NPCObjectScript : MonoBehaviour
{
    public bool npcArrived;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            npcArrived = true;
            other.GetComponent<NPCMotion>().IsWalking = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<NPCMotion>().IsWalking = true;
            npcArrived = false;
        }
        
    }
}
