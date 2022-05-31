using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//C'est le code pour le menu de départ version beta 1.3
public class menuBScript : MonoBehaviour
{

    //Nécessaire pour retirer l'audio
    public GameObject aaaCamera;
    public GameObject activeSonButton;
    public GameObject desactiveSonButton;

    //Niveau en cours
    public int niveauEnCours;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        niveauEnCours = PlayerPrefs.GetInt("Niveau");

        PlayerPrefs.Save();
    }

    //Nouvelle partie
    public void nouvellePartie()
    {
        PlayerPrefs.DeleteKey("Niveau");
        PlayerPrefs.SetInt("Niveau", 1);
        SceneManager.LoadScene("grabberScene");
    }

    //Continuer
    public void continuer()
    {
        // A Quelle niveau suis-je ?
        if (niveauEnCours == 1)
        {
          SceneManager.LoadScene("grabberScene");
        }

        if (niveauEnCours == 2)
        {
          SceneManager.LoadScene("cuisineScene");
        }

        if (niveauEnCours == 3)
        {
          SceneManager.LoadScene("B1Scene");
        }

        if (niveauEnCours == 4)
        {
          SceneManager.LoadScene("B2Scene");
        }
    }

    //Participer à l'emergence du jeu
    public void participer()
    {
        Application.OpenURL("https://www.patreon.com/billmcdonald");
    }

    //Quitter le jeu
    public void quitter()
    {
        Application.Quit();
    }

    //Youtube
    public void youtube()
    {
      Application.OpenURL("https://www.youtube.com/channel/UCU66oZfzU8rX5m_uJeU6GJA");
    }

    //Facebook
    public void facebook()
    {
      Application.OpenURL("https://www.facebook.com/profile.php?id=100078937867739");
    }

    //Pinterest
    public void pinterest()
    {
      Application.OpenURL("www.pinterest.com/billiammcdonald");
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
}
