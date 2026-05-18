using System.Collections.Generic;
using UnityEngine;

public class B1e2 : MonoBehaviour
{
    List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 7, 8, 9, 10 };
    void Start()
    {
        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            print(numbers[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
