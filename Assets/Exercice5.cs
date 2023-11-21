using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercice5 : MonoBehaviour
{
    [SerializeField]
    private float NombreA;
    [SerializeField] private float NombreB;
    [SerializeField] private string operation = "Operation";


    // Start is called before the first frame update
    void Start()
    {
        switch (operation)
        {
            case "addition":
                print(Addition());
                break;

            case "soustraction":
                print(Soustraction());
                break;

            case "division":
                print(Division());
                break;

            case "multiplication":
                print(Multiplication());
                break;

            case "modulo":
                print(Modulo());
                break;

            default:
                Debug.Log("Operation non valide");
                break;
        }
    }

    float Addition()
    {
        float resultat = NombreA + NombreB;
        return resultat;
    }

    float Soustraction()
    {
        float resultat = NombreA - NombreB;
        return resultat;
    }

    float Division()
    {
        float resultat = NombreA / NombreB;
        return resultat;
    }

    float Multiplication()
    {
        float resultat = NombreA * NombreB;
        return resultat;
    }

    float Modulo()
    {
        float resultat = NombreA % NombreB;
        return resultat;
    }
}
