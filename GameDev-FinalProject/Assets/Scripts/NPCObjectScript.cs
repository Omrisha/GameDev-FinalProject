using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class NPCObjectScript : MonoBehaviour
{
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
            var npcMotion = other.GetComponent<NPCMotion>();
            if (CompareTag("PlayerObject"))
            {
                if (!npcMotion.isOnTrain)
                {
                    npcMotion.IsWalking = false;
                    npcMotion.isOnTrain = true;
                    CounterScript.numberOfPeople++;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var npcMotion = other.GetComponent<NPCMotion>();
            if (CompareTag("PlayerObject"))
            {
                if (npcMotion.isOnTrain)
                {
                    npcMotion.IsWalking = true;
                    npcMotion.isOnTrain = false;
                    CounterScript.numberOfPeople--;
                }
            }
        }
    }
}
