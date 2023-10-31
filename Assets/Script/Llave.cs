using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
   
    GameObject puerta;

    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }
}
