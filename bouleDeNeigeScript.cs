using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouleDeNeigeScript : MonoBehaviour
{

    //Tuer le joueur
    public bool B1agentSetDestination;
    public bool B2agentSetDestination;

    //Les agresseurs
    public GameObject agresseur1;
    public GameObject agresseur2;

    Animator animAgresseur1;
    Animator animAgresseur2;

    // Start is called before the first frame update
    void Start()
    {
      animAgresseur1 = agresseur1.GetComponent<Animator>();
      animAgresseur2 = agresseur2.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter (Collider other)
    {
      if (other.gameObject.CompareTag("Ia1"))
      {
        agresseur1.GetComponent<agresseur1Script> ().B1agentSetDestination = true;
        animAgresseur1.SetBool("agresseur1Running",true);
      }

      if (other.gameObject.CompareTag("Ia2"))
      {
        agresseur2.GetComponent<agresseur2Script> ().B2agentSetDestination = true;
        animAgresseur2.SetBool("agresseur2Running",true);
      }
    }
}
