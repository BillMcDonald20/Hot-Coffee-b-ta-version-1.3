using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voitureA2Script : MonoBehaviour
{
  public GameObject voiture;
  public int aaa;
  public bool bouton;

  // Start is called before the first frame update
  void Start()
  {
    aaa = 10;
    bouton = true;
  }

  // Update is called once per frame
  void Update()
  {
      gameObject.transform.Translate(0, 0, -0.1f);

      if (bouton == true)
      {
        StartCoroutine (Patience ());
        bouton = false;
      }

        StartCoroutine (Destruction ());

  }

  IEnumerator Patience ()
  {
      yield return new WaitForSeconds(15);
      GameObject drive = Instantiate (voiture, new Vector3 (1.249f, 1.432f, -8.67f), this.transform.rotation);
      bouton = true;
      aaa = aaa + 5;
  }

  IEnumerator Destruction ()
  {
    yield return new WaitForSeconds(20);
    Destroy(gameObject);
  }
}
