using System.Collections.Generic;
using UnityEngine;

public class B2e9 : MonoBehaviour
{
    List<int> monedas = new List<int>() { 25, 13, 72, 34, 41 };
    void Start()
    {
        int suma = 0;
        for (int i = 0; i < monedas.Count; i++)
        {
            print("monedas" + monedas[i]);
            suma += monedas[i];
        }
        print("monedas: " + suma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
