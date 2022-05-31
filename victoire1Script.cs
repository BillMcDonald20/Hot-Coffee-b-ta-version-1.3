using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class victoire1Script : MonoBehaviour
{
    public float deplacement;

    //text UI
    public GameObject victoireText;

    //defaite Audio
    public GameObject victoireAudio;

    /*Le fond en dégradé
    public GameObject transition;
    A ete remplace*/

    /*la mosaique
    public GameObject banner;
    A ete remplace*/

    //Autre thème musical
    public GameObject otherTheme;
    public GameObject otherTheme2;

    public bool victoireExecuter;

    //Variables de temps
    public int minuteur;
    public bool bouton;

    //Theme Video Raw Image Defaite et victoire
    public GameObject themeVideoRawImageDefVic;

    //Interface utilisateur qui gene
    public GameObject AA;
    public GameObject AB;
    public GameObject AC;

    public GameObject AD;
    public GameObject AE;
    public GameObject AF;

    public GameObject AG;
    public GameObject AH;
    public GameObject AI;
    public GameObject AJ;
    public GameObject AK;

    // Start is called before the first frame update
    void Start()
    {
      victoireExecuter = false;

      //Cela concerne le temps
      minuteur = 240;
    }

    // Update is called once per frame
    void Update()
    {
      //Cela concerne le temps
      if (bouton == true)
      {
        StartCoroutine (Patience ());
        bouton = false;
      }

      //Cela concerne aussi le temps
      if (minuteur == 0)
      {
        SceneManager.LoadScene("histoire1Scene");
      }

      if (victoireExecuter == true)
      {
      deplacement = deplacement + 0.0005f;
      victoire();

      //Cette instruction est nécessaire pour activé le temps
      bouton = true;
      }
    }

    void victoire ()
    {
      /*banner.GetComponent<RawImage>().uvRect = new Rect(deplacement, 0, 1, 1);
      A ete remplace*/
      victoireText.SetActive(true);
      victoireAudio.SetActive(true);
      /*transition.SetActive(true);
      banner.SetActive(true);
      A ete remplace*/
      otherTheme.SetActive(false);
      otherTheme2.SetActive(false);
      //La nouvelle instruction
      themeVideoRawImageDefVic.SetActive(true);

      //2
      AA.SetActive(false);
      AB.SetActive(false);
      AC.SetActive(false);

      AD.SetActive(false);
      AE.SetActive(false);
      AF.SetActive(false);

      AG.SetActive(false);
      AH.SetActive(false);
      AI.SetActive(false);
      AJ.SetActive(false);
      AK.SetActive(false);
    }

    IEnumerator Patience ()
    {
      yield return new WaitForSeconds(1);
      minuteur -= 1;
      bouton = true;
    }
}
