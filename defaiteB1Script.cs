using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class defaiteB1Script : MonoBehaviour
{

    public float deplacement;

    //text UI
    public GameObject defaiteText;

    //defaite Audio
    public GameObject defaiteAudio;

    //Autre thème musical
    public GameObject otherTheme;
    public GameObject otherTheme2;

    public bool defaiteExecuter;

    //Variables de temps
    public int minuteur;
    public bool bouton;

    //Theme Video Raw Image Defaite et victoire
    public GameObject OthemeVideoRawImageDefVic;

    //Interface utilisateur qui gene
    public GameObject BA;
    public GameObject BB;
    public GameObject BC;

    public GameObject BD;
    public GameObject BE;
    public GameObject BF;

    public GameObject BG;
    public GameObject BH;
    public GameObject BI;
    public GameObject BJ;

    public GameObject BK;
    public GameObject BL;
    public GameObject BM;
    public GameObject BN;
    public GameObject BO;

    // Start is called before the first frame update
    void Start()
    {
      defaiteExecuter = false;

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
        SceneManager.LoadScene("menu2Scene");
      }

      if (defaiteExecuter == true)
      {
      deplacement = deplacement + 0.0005f;
      defaite();

      //Cette instruction est nécessaire pour activé le temps
      bouton = true;
      }
    }

    void defaite()
    {
      //banner.GetComponent<RawImage>().uvRect = new Rect(deplacement, 0, 1, 1);
      defaiteText.SetActive(true);
      defaiteAudio.SetActive(true);
      //transition.SetActive(true);
      //banner.SetActive(true);
      otherTheme.SetActive(false);
      otherTheme2.SetActive(false);
      OthemeVideoRawImageDefVic.SetActive(true);

      //2
      BA.SetActive(false);
      BB.SetActive(false);
      BC.SetActive(false);

      BD.SetActive(false);
      BE.SetActive(false);
      BF.SetActive(false);

      BG.SetActive(false);
      BH.SetActive(false);
      BI.SetActive(false);
      BJ.SetActive(false);

      BK.SetActive(false);
      BL.SetActive(false);
      BM.SetActive(false);
      BN.SetActive(false);
      BO.SetActive(false);
    }

    IEnumerator Patience ()
    {
      yield return new WaitForSeconds(1);
      minuteur -= 1;
      bouton = true;
    }
}
