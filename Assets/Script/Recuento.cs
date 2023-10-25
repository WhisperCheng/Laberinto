using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Recuento : MonoBehaviour
{
    public TMP_Text recuento;
    private int monedas;
    

    // Start is called before the first frame update
    void Start()
    {
        monedas = 0;
        recuento.text = "Contador = ";
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Monedas") 
        {
            monedas++;
            recuento.text = "monedas" + monedas;
        }
    }
}
