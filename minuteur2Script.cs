using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class minuteur2Script : MonoBehaviour

//Ce script est utilisé dans Grabber

{
    public int minuteur;
    public GameObject minuteurUI;
    public bool bouton;

    //Objet defaite
    public GameObject defaite;

    //Objet thème sonore
    public GameObject otherTheme;
    public GameObject otherTheme2;


    // Start is called before the first frame update
    void Start()
    {
        minuteur = 45;
        bouton = true;
    }

    // Update is called once per frame
    void Update()
    {

      if (bouton == true)
      {
        StartCoroutine (Patience ());
        bouton = false;
      }

        minuteurUI.GetComponent<TextMeshProUGUI> ().text = ("0:") + minuteur.ToString();

      if (minuteur == 0)
      {
        /*Cette instruction n'est plus valable
        SceneManager.LoadScene("menuDepartScene");*/

        defaite.GetComponent<defaite1Script>().defaiteExecuter = true;
      }

      //Changer le theme sonore
      if (minuteur < 15)
      {
        otherTheme.SetActive(false);
        otherTheme2.SetActive(true);
      }
    }

    IEnumerator Patience ()
    {
      yield return new WaitForSeconds(1);
      minuteur -= 1;
      bouton = true;
    }
}
