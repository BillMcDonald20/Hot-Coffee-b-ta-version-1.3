using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class scoreScript : MonoBehaviour
{

    public GameObject scoreUI;
    public int score;

    //PNJ GameObject
    public GameObject PNJA;
    Animator animA;
    public GameObject PNJB;
    Animator animB;
    public GameObject PNJC;
    Animator animC;

    //important
    public bool vax;
    public bool bex;
    public bool fix;

    //Variables nécessaires pour lancer la transition defaite
    public GameObject victoireV;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        animA = PNJA.GetComponent<Animator>();
        animB = PNJB.GetComponent<Animator>();
        animC = PNJC.GetComponent<Animator>();

        //important
        vax = true;
        bex = true;
        fix = true;
    }

    // Update is called once per frame
    void Update()
    {
      scoreUI.GetComponent<TextMeshProUGUI> ().text = score.ToString();

      if (score == 600)
      {
        /*Cette instruction ne tient plus
        SceneManager.LoadScene("menuDepartScene");*/
        victoireV.GetComponent<victoire1Script>().victoireExecuter = true;
      }
    }

    void OnTriggerEnter (Collider other)
    {
    if (other.gameObject.CompareTag("Ia1"))
      {
        PNJA.tag = "Ia";
        //animA.SetBool ("running",false);
        animA.SetBool ("pain",true);
        animA.GetComponent<iaPNJScript> ().agentSetDestination = false;
      }

    if (other.gameObject.CompareTag("Ia2"))
      {
        PNJB.tag = "Ia";
        //animB.SetBool ("running",false);
        animB.SetBool ("pain",true);
        animB.GetComponent<iaPNJ2Script> ().agentSetDestination = false;
      }

    if (other.gameObject.CompareTag("Ia3"))
      {
        PNJC.tag = "Ia";
        //animC.SetBool ("running",false);
        animC.SetBool ("pain",true);
        animC.GetComponent<iaPNJ3Script> ().agentSetDestination = false;
      }

    if((animA.GetComponent<iaPNJScript> ().agentSetDestination == false) && (vax == true))
      {
        score += 200;
        vax = false;
      }

    if((animB.GetComponent<iaPNJ2Script> ().agentSetDestination == false) && (bex == true))
      {
        score += 200;
        bex = false;
      }

    if((animC.GetComponent<iaPNJ3Script> ().agentSetDestination == false) && (fix == true))
      {
        score += 200;
        fix = false;
      }
    }
}
