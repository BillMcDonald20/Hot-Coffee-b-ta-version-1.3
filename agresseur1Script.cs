using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agresseur1Script : MonoBehaviour
{
    //objet vie "il est vide"
    public GameObject vie;

    NavMeshAgent agent;

    public GameObject joueur;

    //Tuer le joueur
    public bool B1agentSetDestination;

    //Objet victoire & defaite, utile pour empecher les IA de suivre le joueur lorsque...vous connaissez
    public GameObject victoire;
    public GameObject defaite;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent <NavMeshAgent>();
        B1agentSetDestination = false;
    }

    // Update is called once per frame
    void Update()
    {
      if (B1agentSetDestination == true)
      {
        agent.SetDestination (joueur.transform.position);
      }

      if (B1agentSetDestination == false)
      {
      agent.SetDestination (this.transform.position);
      }

      //Empecher l'IA de suivre le joueur
      if (victoire.GetComponent<victoire1Script>().victoireExecuter == true)
      {
        agent.SetDestination (this.transform.position);
      }

      if (defaite.GetComponent<defaite1Script>().defaiteExecuter == true)
      {
        agent.SetDestination (this.transform.position);
      }
    }

    void OnTriggerStay (Collider other)
    {
      if (other.gameObject.CompareTag("Player"))
      {
        vie.GetComponent<vieScript>().currentHP -= 10f;
      }

      if (other.gameObject.CompareTag("Player") && other.gameObject.CompareTag("Ia2"))
      {
        vie.GetComponent<vieScript>().currentHP -= 10f;
      }
    }
}
