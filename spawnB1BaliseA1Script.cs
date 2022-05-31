using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnB1BaliseA1Script : MonoBehaviour
{
    //Alerte
    public bool alerte;

    public float xaa;
    public float zaa;

    public float xbb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (GameObject.Find("Joueur").GetComponent<joueurB1Script>().goAlerte == true)
      {
        gameObject.transform.position = new Vector3 (xaa,1.61f,zaa);
        alerte = true;
      }

      if (GameObject.Find("Joueur").GetComponent<joueurB1Script>().goAlerte == false)
      {
        gameObject.transform.position = new Vector3 (xbb,1.61f,-19.7f);
        alerte = false;
      }
    }

    //A revoir
    void OnTriggerEnter (Collider other)
    {
    if (other.gameObject.CompareTag("Ia1"))
      {
        xaa = Random.Range(-21.76f, 22f);
        zaa = Random.Range(-18f, -19.45f);
      }

    if (other.gameObject.CompareTag("Ia1"))
      {
        xbb = Random.Range(-21.76f, 22f);
      }
    }
}
