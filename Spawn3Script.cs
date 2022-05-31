using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn3Script : MonoBehaviour
{

      public bool alerte;

      public float xaa;
      public float zaa;

      public float xbb;
      public float zbb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Joueur").GetComponent<joueurScript>().goAlerte == true)
        {
          gameObject.transform.position = new Vector3 (xaa,1.15f,zaa);
          alerte = true;
        }

        if (GameObject.Find("Joueur").GetComponent<joueurScript>().goAlerte == false)
        {
          gameObject.transform.position = new Vector3 (xbb,1.15f,zbb);
          alerte = false;
        }
    }

    //A revoir
    void OnTriggerEnter (Collider other)
    {
    if (other.gameObject.CompareTag("Ia3"))
      {
        xaa = Random.Range(0.10f, 2.10f);
        zaa = Random.Range(-7.5f, 9.5f);
      }

    if (other.gameObject.CompareTag("Ia3"))
      {
        xbb = Random.Range(1.73f, 2.06f);
        zbb = Random.Range(-8.65f, 10.54f);
      }
    }
}
