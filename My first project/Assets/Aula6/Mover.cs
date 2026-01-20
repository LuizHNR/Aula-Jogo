using UnityEngine;

public class Mover : MonoBehaviour
{
    // 

    

    // Vai executar uma vez quando ele iniciar
    void Start()
    {
        // Vector3 quando for 3D o Vector2 quando for 2D
        // transform.position é a sitaxe para para mudar a posição do objeto
        transform.position = new Vector3(-5.0f, 0.0f, 0.0f);

    }

    // Realiza varias vezes
    void Update()
    {
        
    }
}
