using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercice2 : MonoBehaviour
{
    [SerializeField] private int[] nombresEntiers;
    // Start is called before the first frame update
    void Start()
    {
        int result = 0;

        foreach(int variable in nombresEntiers)
        {
            result += variable;
            int resultpair = variable % 2; 

            if (resultpair == 0)
            {
                resultpair++; 
            }
            else
            {
                resultpair++; 
            }

        }
        Debug.Log(result); 

    }

}
