using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
   
    GameObject puerta;
    public AudioSource FXllave;

    // Start is called before the first frame update
    void Start()
    {
        FXllave = GameObject.Find("FXLlave").GetComponent<AudioSource>();
        puerta = GameObject.Find("Puerta");
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Personaje")
        {
            Destroy(puerta);
            Destroy(gameObject);
            FXllave.Play();
        }
    }
}
