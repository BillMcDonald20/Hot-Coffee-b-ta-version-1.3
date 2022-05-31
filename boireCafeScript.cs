using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class boireCafeScript : MonoBehaviour
{

  public GameObject canvasObject;
  public GameObject videoCinematic;

    // Start is called before the first frame update
    void Start()
    {
      GetComponent<PlayableDirector>().playableGraph.GetRootPlayable(0).SetSpeed(0);
    }

    // Update is called once per frame
    void Update()
    {
      //Instruction pour jouer l'animation
      if (Input.GetKeyDown(KeyCode.E))
      {
        GetComponent<PlayableDirector>().playableGraph.GetRootPlayable(0).SetSpeed(1);
        StartCoroutine (cinematique());
        StartCoroutine (nouveauNiveau());
      }
    }

    IEnumerator cinematique ()
    {
      yield return new WaitForSeconds (4);
      canvasObject.SetActive(true);
      videoCinematic.GetComponent<VideoPlayer>().Play();
    }

    IEnumerator nouveauNiveau ()
    {
      yield return new WaitForSeconds (25);
      SceneManager.LoadScene("histoire2Scene");
    }
}
