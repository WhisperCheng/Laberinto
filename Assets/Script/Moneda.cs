using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{

    public AudioSource FXmoneda;
    // Start is called before the first frame update
    void Start()
    {
        FXmoneda = GameObject.Find("FXMoneda").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Personaje")
            Destroy(gameObject);
            FXmoneda.Play();
    }
}
