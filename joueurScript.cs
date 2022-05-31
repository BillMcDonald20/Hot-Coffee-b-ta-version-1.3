using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joueurScript : MonoBehaviour
{
    public float deplacement;
    public GameObject ball;

    //Déclaration des variables de santé
    public float currentSante;
    public float maxSante = 100f;
    public float currentBarLength;
    public float maxBarLength = 400f;

    RectTransform rt;
    public GameObject uiBar;

    //Audio
    public bool bouton;
    AudioSource enduranceFaibleAudioSource;

    //Activation de alerte
    public bool goAlerte;

    // Start is called before the first frame update
    void Start()
    {
        deplacement = 0.05f;
        currentSante = 100f;

        //Audio
        bouton = false;
        enduranceFaibleAudioSource = gameObject.GetComponent<AudioSource>();

        //Alerte
        goAlerte = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (currentSante < 100f)
        {
          restoreSante();
        }

        if (currentSante < 66f)
        {
          deplacement = 0.025f;
        }

        if (currentSante > 66f)
        {
          deplacement = 0.05f;
        }

        if (currentSante < 33f)
        {
          deplacement = 0f;
          bouton = true;
            if (bouton == true)
              {
                enduranceFaibleAudioSource.Play();
                StartCoroutine (Patience ());
                bouton = false;
              }
        }

        //Code pour déplacement en avant
        if(Input.GetAxis ("Vertical") > 0)
        {
            gameObject.transform.Translate(0,0,deplacement);

            //Dégradation de l'énergie
            currentSante -= 0.5f;
        }

        //Code pour pivoter camera à droite
        if(Input.GetAxis ("Mouse X") > 0)
        {
            gameObject.transform.Rotate(0,3f,0);
        }

        //Code pour pivoter camera à gauche
        if(Input.GetAxis ("Mouse X") < 0)
        {
            gameObject.transform.Rotate(0,-3f,0);
        }

        //Code pour instancier un objet et le tirer depuis un autre objet du jeu.
        if(Input.GetKeyDown ("space"))
        {
            GameObject shot = Instantiate (ball, this.transform.position, this.transform.rotation);
            shot.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            goAlerte = true;
        }

        //SanteBar
        currentBarLength = currentSante * maxBarLength / maxSante;

        RectTransform rt = uiBar.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(currentBarLength, 12);
    }

    void restoreSante ()
    {
        currentSante += 0.25f;
    }

    IEnumerator Patience ()
    {
      yield return new WaitForSeconds(10);
      enduranceFaibleAudioSource.Stop();
      bouton = false;
    }
}
