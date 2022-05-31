using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class iaPNJ2Script : MonoBehaviour
{
    NavMeshAgent agent;

    Animator anim;

    public GameObject Balise2;

    //tuerIa
    public bool agentSetDestination;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent <NavMeshAgent>();
        anim = gameObject.GetComponent<Animator>();
        agentSetDestination = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Balise2.GetComponent<Spawn2Script> ().alerte == true)
        {
        //état "running"
        anim.SetBool ("running",true);
        }

        if (Balise2.GetComponent<Spawn2Script> ().alerte == false)
        {
        //état "walk"
        anim.SetBool ("running",false);
        }

        if (agentSetDestination == true)
        {
        agent.SetDestination (Balise2.transform.position);
        }

        if (agentSetDestination == false)
        {
        agent.SetDestination (this.transform.position);
        }
    }
}
