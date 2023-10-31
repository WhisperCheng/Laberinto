using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    bool pillado;

    // Start is called before the first frame update
    void Start()
    {
        pillado = false;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Personaje")
        {
            Destroy(gameObject);
            pillado = true;
        }
        if (pillado == true)
        {
            collision.gameObject.CompareTag("Puerta");
            Destroy(gameObject);
        }
 

    }
}
