using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class iaPNJ3Script : MonoBehaviour
{
    NavMeshAgent agent;

    Animator anim;

    public GameObject Balise3;

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
      if (Balise3.GetComponent<Spawn3Script> ().alerte == true)
      {
      //état "running"
      anim.SetBool ("running",true);
      }

      if (Balise3.GetComponent<Spawn3Script> ().alerte == false)
      {
      //état "walk"
      anim.SetBool ("running",false);
      }

      if (agentSetDestination == true)
      {
      agent.SetDestination (Balise3.transform.position);
      }

      if (agentSetDestination == false)
      {
      agent.SetDestination (this.transform.position);
      }
    }
}
