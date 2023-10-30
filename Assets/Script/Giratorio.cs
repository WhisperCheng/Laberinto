using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giratorio : MonoBehaviour
{

    public float fuerza;

    // Start is called before the first frame update
    void Start()
    {
        fuerza = 110f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (Vector3.forward * fuerza * Time.deltaTime);
    }
}
