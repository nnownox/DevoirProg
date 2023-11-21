using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercice1 : MonoBehaviour
{
    [SerializeField] private float celcius;


    // Start is called before the first frame update
    void Start()
    {
        float kelvinresult = celcius + 273.15f;
        Debug.Log(kelvinresult);

        float fahrenheintresult = (celcius * 9 / 5) + 32;
        Debug.Log(fahrenheintresult);

            
    }

}
