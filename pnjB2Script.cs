using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pnjB2Script : MonoBehaviour
{

    NavMeshAgent agent;

    Animator anim;

    public GameObject BaliseA1;

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
      if (BaliseA1.GetComponent<spawnB1BaliseA1Script> ().alerte == true)
      {
      //état "running"
      anim.SetBool ("running",true);
      }

      if (BaliseA1.GetComponent<spawnB1BaliseA1Script> ().alerte == false)
      {
      //état "walk"
      anim.SetBool ("running",false);
      }

      if (agentSetDestination == true)
      {
      agent.SetDestination (BaliseA1.transform.position);
      }

      if (agentSetDestination == false)
      {
      agent.SetDestination (this.transform.position);
      }
    }
}
