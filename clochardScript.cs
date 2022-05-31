using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class clochardScript : MonoBehaviour
{
    public GameObject agresseurA;
    public GameObject agresseurB;
    //public bool clochardLibre2 ;

    public GameObject clochardSpawn;

    NavMeshAgent agent;

    Animator animClochard;

    //public bool clochardLibre2;

    //Variable pour la victoire
    public GameObject victoire;

    //Variable pour le minuteur
    public int minuteur;
    public bool bouton;

    public GameObject minuteurUI;

    // Start is called before the first frame update
    void Start()
    {
      //clochardLibre2 = agresseur.GetComponent<agresseur1Script>().clochardLibre;

      animClochard = gameObject.GetComponent<Animator>();
      animClochard.SetBool("zombieCrawlBool",false);

      agent = GetComponent <NavMeshAgent>();

      //Cela concerne le temps
      minuteur = 480;
    }

    // Update is called once per frame
    void Update()
    {
      if (agresseurA.GetComponent<agresseur1Script>().B1agentSetDestination && agresseurB.GetComponent<agresseur2Script>().B2agentSetDestination == true)
      {
        agent.SetDestination(clochardSpawn.transform.position);
        animClochard.SetBool("zombieCrawlBool",true);
        bouton = true;

        //Arreter le minuteur UI, qui est invisible
        minuteurUI.GetComponent<minuteur2Script>().minuteur = 120;
      }

      //Cela concerne le temps
      if (bouton == true)
      {
        StartCoroutine (Patience ());
        bouton = false;
      }

      //Cela concerne aussi le temps
      if (minuteur == 0)
      {
        victoire.GetComponent<victoire1Script>().victoireExecuter = true;
      }
    }

    IEnumerator Patience ()
    {
      yield return new WaitForSeconds(1);
      minuteur -= 1;
      bouton = true;
    }
}
