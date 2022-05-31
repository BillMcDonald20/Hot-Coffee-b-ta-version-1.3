using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseScript : MonoBehaviour
{
    public GameObject menuPauseA;
    public GameObject menuPauseB;
    public GameObject pauseText;
    public GameObject WWpauseText;
    public GameObject reprendreButton;
    public GameObject activeSonButton;
    public GameObject desactiveSonButton;
    public GameObject menuButton;
    public GameObject quitterButton;

    //Nécessaire pour retirer l'audio
    public GameObject aaaCamera;


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

        menuPauseA.SetActive(true);
        menuPauseB.SetActive(true);
        pauseText.SetActive(true);
        WWpauseText.SetActive(true);
        reprendreButton.SetActive(true);
        activeSonButton.SetActive(true);
        desactiveSonButton.SetActive(false);
        menuButton.SetActive(true);
        quitterButton.SetActive(true);
    }

    //Désactivation du menu pause
    public void noMenuPause()
    {
        Time.timeScale = 1;

        menuPauseA.SetActive(false);
        menuPauseB.SetActive(false);
        pauseText.SetActive(false);
        WWpauseText.SetActive(false);
        reprendreButton.SetActive(false);
        activeSonButton.SetActive(false);
        desactiveSonButton.SetActive(false);
        menuButton.SetActive(false);
        quitterButton.SetActive(false);
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
        SceneManager.LoadScene("menuDepartScene");
    }

    //Quitter le jeu
    public void quitter()
    {
        Application.Quit();
    }
  }
