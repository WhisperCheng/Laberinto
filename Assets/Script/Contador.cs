using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class Texto : MonoBehaviour
{
    public TMP_Text Contador;
    public float tiempo = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        Contador.text = tiempo.ToString("F2");
    }


}
