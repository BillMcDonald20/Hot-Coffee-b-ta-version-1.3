using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class minuteurScript : MonoBehaviour
{

    public int minuteur;
    public GameObject minuteurUI;
    public bool bouton;

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
        SceneManager.LoadScene("menuDepartScene");
      }
    }

    IEnumerator Patience ()
    {
      yield return new WaitForSeconds(1);
      minuteur -= 1;
      bouton = true;
    }
}
