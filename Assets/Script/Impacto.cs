using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Impacto : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    public float tiempo;
    Vector2 empuje;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        tiempo = 2f;
        empuje = new Vector2(10, 0);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paredes")
        {
            transform.Translate(empuje * Time.fixedDeltaTime * 10);
            sr.color = Color.red;
        }
    }
}
