using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Final : MonoBehaviour
{

    public AudioSource MusicFondo;
    // Start is called before the first frame update
    void Start()
    {
        MusicFondo = GameObject.Find("Musica de fondo").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0f;
        MusicFondo.Stop();
    }
}
