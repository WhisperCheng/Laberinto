using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lateral : MonoBehaviour
{
    public int velocidad;
    bool direccion;



    // Start is called before the first frame update
    void Start()
    {
        velocidad = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 6.5) 
        {
            direccion = false;
        }
        else if (transform.position.x < 5.5)
        {
            direccion = true;
        }
        if (direccion == true)
        {
            transform.Translate(Vector2.right * velocidad * Time.deltaTime);
        }
        else if (direccion == false)
        {
            transform.Translate (Vector2.left * velocidad * Time.deltaTime);
        }
    }

}
