using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giratorioinverso : MonoBehaviour
{
    // Start is called before the first frame update

    public float fuerza;

    void Start()
    {
        fuerza = 85f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (Vector3.back * fuerza * Time.deltaTime);
    }
}
