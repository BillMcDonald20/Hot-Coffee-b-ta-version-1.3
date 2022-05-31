using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileScript : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Code pour instancier un objet et le tirer depuis un autre objet du jeu.
        if(Input.GetKeyDown ("space"))
        {
            GameObject shot = Instantiate (ball, this.transform.position, this.transform.rotation);
            shot.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
        }

        //Code pour déplacement en avant
        if(Input.GetAxis ("Horizontal") > 0)
        {
            gameObject.transform.Translate(0.1f,0,0);
        }

        //Code pour déplacement en arrière
        if(Input.GetAxis ("Horizontal") < 0)
        {
            gameObject.transform.Translate(-0.1f,0,0);
        }

        //Code pour déplacement à droite
        if(Input.GetAxis ("Vertical") > 0)
        {
            gameObject.transform.Translate(0,0,0.1f);
        }

        //Code pour déplacement à gauche
        if(Input.GetAxis ("Vertical") < 0)
        {
            gameObject.transform.Translate(0,0,-0.1f);
        }
    }
}
