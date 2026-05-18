using System.Collections.Generic;
using UnityEngine;

public class B2e7 : MonoBehaviour
{
    List<string> enemigos = new List<string>() {"esqueleto", "creeper", "zombie", "dragon", "ghast", "blazes"};
    void Start()
    {
        for (int i = 0; i < enemigos.Count; i++)
        {
            print(enemigos[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
