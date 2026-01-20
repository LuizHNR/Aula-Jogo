using UnityEngine;

public class Girar : MonoBehaviour
{

    void Update()
    {
        float ry = Input.GetAxis("Horizontal") * 5.0f;

        float rx = Input.GetAxis("Vertical") * 5.0f;

        // transform.Rotate é a sitaxe para para mudar a rotação do objeto
        transform.Rotate(rx, ry, 0.0f);
    }
}
