using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

//Ce script est utilisé pour la scène grabber
public class vieScript : MonoBehaviour
{
    //Déclaration de variables de HealthBar
    public float currentHP;
    public float maxHP = 100f;
    public float currentBarLength;
    public float maxBarLength = 400f;
    RectTransform rt;

    public GameObject uiBar;

    //Objet defaite
    public GameObject defaite;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = 100f;
    }

    // Update is called once per frame
    void Update()
    {
      //HealthBar
      currentBarLength = currentHP * maxBarLength / maxHP;

      RectTransform rt = uiBar.GetComponent<RectTransform>();
      rt.sizeDelta = new Vector2(currentBarLength, 50);

      if (currentHP == 0)
      {
        /*Cette instruction n'est plus envisagé
        SceneManager.LoadScene("menuDepartScene");*/

        //Cette instruction par contre
        defaite.GetComponent<defaite1Script>().defaiteExecuter = true;
      }
    }
}
