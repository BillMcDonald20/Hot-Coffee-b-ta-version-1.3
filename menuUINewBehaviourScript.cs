using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//C'est le code pour le menu de départ
public class menuUINewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Tester le jeu
    public void tester()
    {
        SceneManager.LoadScene("Niveau1Scene");
    }

    //Tester l'histoire
    public void histoire()
    {
        SceneManager.LoadScene("grabberScene");
    }

    //Participer le jeu
    public void participer()
    {
        Application.OpenURL("https://www.patreon.com/billmcdonald");
    }

    //Quitter le jeu
    public void quitter()
    {
        Application.Quit();
    }
}
