using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DoWhile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void For()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("For Executed " + i);
        }
    }

    void While()
    {
        int i = 0;

        while (i < 10)
        {
            Debug.Log("While Executed " + i);
            i++;
        }
    }

    void DoWhile()
    {
        int i = 0;
        do
        {
            Debug.Log("Do While Executed " + i);
            i++;
        } while (i<10);
    }
}
