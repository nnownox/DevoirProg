using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercice3 : MonoBehaviour
{
    [SerializeField]
    [Min (100)]
    private int Nombre;

    // Start is called before the first frame update
    void Start()
    {
        int centaines = 0;
        int dizaines = 0;
        int unites = 0;

        unites = Nombre % 10;
        dizaines = (Nombre % 100)/ 10;
        centaines = (Nombre % 1000)/100;

        //centaines = centaines - dizaines;
        //dizaines = dizaines - unites;

        Debug.Log(centaines);
        Debug.Log(dizaines);
        Debug.Log(unites);
    }

}
