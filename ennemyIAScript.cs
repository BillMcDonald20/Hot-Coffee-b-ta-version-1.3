using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ennemyIAScript : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject player;

    //Déclaration de variables de HealthBar
    public float currentHP;
    public float maxHP = 100f;
    public float currentBarLength;
    public float maxBarLength = 400f;
    RectTransform rt;

    public GameObject uiBar;

    //Variables nécessaires pour lancer la transition defaite
    public GameObject defaiteV;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent <NavMeshAgent>();

        currentHP = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination (player.transform.position);

        //HealthBar
        currentBarLength = currentHP * maxBarLength / maxHP;

        RectTransform rt = uiBar.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(currentBarLength, 50);
        //currentHP = GameObject.Find ("policierRunning").GetComponent<ennemyIAScript> ().c2urrentHP;

        if (currentHP == 0)
        {
          /*Cette instruction ne tient plus
          SceneManager.LoadScene("menuDepartScene");*/
          defaiteV.GetComponent<defaite1Script>().defaiteExecuter = true;
        }
    }

    void OnTriggerStay (Collider other)
    {
      if (other.gameObject.CompareTag("Player"))
      {
        currentHP -= 10f;
      }
    }

}
