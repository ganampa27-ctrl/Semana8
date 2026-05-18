using UnityEngine;

public class B2e6 : MonoBehaviour
{
    string[] inventario = new string[5] { "espada", "pastel", "escudo", "pocion", "pizza"   };
    void Start()
    {
        foreach (string item in inventario)
        {
            
            print(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
