using UnityEngine;

public class B1e4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            if (i % 2 == 0)
                print(i + " es par");
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
