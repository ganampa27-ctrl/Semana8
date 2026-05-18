
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    List<int> numbers = new List<int>() {1,2,3,4,5 };
    void Start()
    {

        foreach(int number in numbers)
        {
            if (number == 3 || number == 1)
                continue;
            print(number);
        }

        /*for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }
        for (int i = 0; i < 10; i+=2)
        {
            Debug.Log(i);
        }
        */
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
