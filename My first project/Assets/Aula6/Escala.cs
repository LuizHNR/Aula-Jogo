using UnityEngine;

public class Escala : MonoBehaviour
{
    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    //{
    //    // transform.localScale é a sitaxe para para mudar a escala (tamanho) do objeto
    //    transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
    //}

    // Update is called once per frame

    float s = 1.0f;
    void Update()
    {
        if (Input.GetButtonDown("Jump")) 
        {
            s = s + 0.03f;
            transform.localScale = new Vector3(s, s, s);
        }
    }
}
