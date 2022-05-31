using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class scoreB1SceneScript : MonoBehaviour
{

    //PNJ GameObject
    public GameObject PNJA;
    Animator animA;

    //important
    public bool vax;

    public GameObject scoreUI;
    public int score;

    //Variables nécessaires pour lancer la transition defaite
    public GameObject victoireV;

    // Start is called before the first frame update
    void Start()
    {
      score = 0;

      animA = PNJA.GetComponent<Animator>();

      //important
      vax = true;
    }

    // Update is called once per frame
    void Update()
    {
      scoreUI.GetComponent<TextMeshProUGUI> ().text = score.ToString();

      if (score == 200)
      {
        victoireV.GetComponent<victoireB1SceneScript>().victoireExecuter = true;
      }
    }

    void OnTriggerEnter (Collider other)
    {
    if (other.gameObject.CompareTag("Ia1"))
      {
        PNJA.tag = "Ia";
        animA.SetBool ("pain",true);
        animA.GetComponent<pnjB2Script> ().agentSetDestination = false;
      }

      if((animA.GetComponent<pnjB2Script> ().agentSetDestination == false) && (vax == true))
        {
          score += 200;
          vax = false;
        }
      }
}
