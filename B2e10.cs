using UnityEngine;

public class B2e10 : MonoBehaviour
{
    string[] niveles = new string[5] { "nivel 1", "nivel 2", "nivel 3", "nivel 4", "nivel 5" };
    void Start()
    {
        foreach (string nivel in niveles)
        {
            print(nivel + " ha sido desbloqueado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
