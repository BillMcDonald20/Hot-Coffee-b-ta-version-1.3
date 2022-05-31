using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPolicierScript : MonoBehaviour
{
    AudioSource policierAudio ;

    // Start is called before the first frame update
    void Start()
    {
        policierAudio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter (Collider other)
    {
          if (other.gameObject.CompareTag("Player"))
              {
                policierAudio.Play();
              }
    }
}
