using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Personaje : MonoBehaviour
{

    private Rigidbody2D cuerpo;
    private SpriteRenderer rojo;
    float tiempo;
    bool chocado;
    public float impulso;
    float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
        rojo = GetComponent<SpriteRenderer>();
        tiempo = 0f;
        chocado = false;
        impulso = 2.5f;
        velocidad = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        

        if (chocado == true)
        {
            tiempo += Time.deltaTime;
            rojo.color = Color.red;


            if (tiempo > 2) 
            {
                // ya no me he chocado
                chocado = false;
                rojo.color = Color.white;
            }
        }
        else
        {
            cuerpo.velocity = new Vector2(movHorizontal * velocidad, movVertical * velocidad);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paredes")
        {
            tiempo = 0;
            // me he chocado
            chocado = true;
            cuerpo.AddForce(collision.GetContact(0).normal * impulso);
        }
    }

}
