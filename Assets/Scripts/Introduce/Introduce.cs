using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduce : MonoBehaviour
{
    int[] data = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = Random.Range(10, 5);
        }
        for (int i = 0; i < data.Length; i++)
        {
            Debug.Log(data[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
