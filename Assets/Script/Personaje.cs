using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Personaje : MonoBehaviour
{

    private Rigidbody2D cuerpo;
    public TMP_Text recuento;
    private int monedas;

    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
        monedas = 0;
        recuento.text = "Contador =";
    }

    // Update is called once per frame
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        cuerpo.velocity = new Vector2(movHorizontal * 3, movVertical * 3);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Monedas")
        {
            monedas++;
            recuento.text = "Contador = " + monedas;
        }
    }
}
