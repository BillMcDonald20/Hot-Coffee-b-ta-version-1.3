using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pause2VarianteAScript : MonoBehaviour
{
  public GameObject pauseText;
  public GameObject WWpauseText;
  public GameObject reprendreButton;
  public GameObject activeSonButton;
  public GameObject desactiveSonButton;
  public GameObject menuButton;
  public GameObject quitterButton;

  //Nécessaire pour retirer l'audio
  public GameObject aaaCamera;

  //Le nouveau theme Pause
  public GameObject themeVideoPause;

  //Interface utilisateur qui gene
  public GameObject CA;
  public GameObject CB;
  public GameObject CC;

  public GameObject CD;
  public GameObject CE;
  public GameObject CF;

  public GameObject CG;
  public GameObject CH;
  public GameObject CI;
  public GameObject CJ;
  public GameObject CK;

  public GameObject CL;
  public GameObject CM;
  public GameObject CN;
  public GameObject CO;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Activation du menu pause
    public void menuPause()
    {
        Time.timeScale = 0;

        //menuPauseA.SetActive(true);
        //menuPauseB.SetActive(true);

        pauseText.SetActive(true);
        WWpauseText.SetActive(true);
        reprendreButton.SetActive(true);
        activeSonButton.SetActive(true);
        desactiveSonButton.SetActive(false);
        menuButton.SetActive(true);
        quitterButton.SetActive(true);

        themeVideoPause.SetActive(true);

        //2
        CA.SetActive(false);
        CB.SetActive(false);
        CC.SetActive(false);

        CD.SetActive(false);
        CE.SetActive(false);
        CF.SetActive(false);

        CG.SetActive(false);
        CH.SetActive(false);
        CI.SetActive(false);
        CJ.SetActive(false);
        CK.SetActive(false);

        CL.SetActive(false);
        CM.SetActive(false);
        CN.SetActive(false);
        CO.SetActive(false);
    }

    //Désactivation du menu pause
    public void noMenuPause()
    {
        Time.timeScale = 1;

        //menuPauseA.SetActive(false);
        //menuPauseB.SetActive(false);

        pauseText.SetActive(false);
        WWpauseText.SetActive(false);
        reprendreButton.SetActive(false);
        activeSonButton.SetActive(false);
        desactiveSonButton.SetActive(false);
        menuButton.SetActive(false);
        quitterButton.SetActive(false);

        themeVideoPause.SetActive(false);

        //2
        CA.SetActive(true);
        CB.SetActive(true);
        CC.SetActive(true);

        CD.SetActive(true);
        CE.SetActive(true);
        CF.SetActive(true);

        CG.SetActive(true);
        CH.SetActive(true);
        CI.SetActive(true);
        CJ.SetActive(true);
        CK.SetActive(true);

        CL.SetActive(true);
        CM.SetActive(true);
        CN.SetActive(true);
        CO.SetActive(true);

        //Remettre le minuteur en marche
        GameObject.Find("minuteurUI (prefab)").GetComponent<minuteurB1Script>().bouton = true;
    }

    //Retirer le son
    public void noSound()
    {
        aaaCamera.GetComponent<AudioListener>().enabled = false;
        activeSonButton.SetActive(false);
        desactiveSonButton.SetActive(true);
    }

    //Activer le son
    public void yesSound()
    {
      aaaCamera.GetComponent<AudioListener>().enabled = true;
      activeSonButton.SetActive(true);
      desactiveSonButton.SetActive(false);
    }

    //Menu
    public void retourMenu()
    {
        SceneManager.LoadScene("menu2Scene");
    }

    //Quitter le jeu
    public void quitter()
    {
        Application.Quit();
    }
  }
