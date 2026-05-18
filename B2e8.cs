using UnityEngine;

public class B2e8 : MonoBehaviour
{
    int[] puntaje = new int[10] { 10, 24, 36, 47, 59, 63, 78, 82, 91, 102 };
    void Start()
    {
         foreach (int i in puntaje)
        {
                print(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
