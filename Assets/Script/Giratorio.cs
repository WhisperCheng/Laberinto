using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giratorio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (Vector3.forward * 60 * Time.deltaTime);
    }
}
