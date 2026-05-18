using System.Collections.Generic;
using UnityEngine;

public class B1e1 : MonoBehaviour
{
    List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 7, 8 , 9, 10};
    void Start()
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            print(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
