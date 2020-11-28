using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalScript : MonoBehaviour
{
    public NPCMotion npc1;
    public NPCMotion npc2;
    public NPCMotion npc3;
    public NPCMotion npc4;
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
        if (other.CompareTag("Train"))
        {
            npc1.ChangeTarget();
            npc2.ChangeTarget();
            npc3.ChangeTarget();
            npc4.ChangeTarget();    
        }
    }

    
}
