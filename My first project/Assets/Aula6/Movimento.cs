using System.Collections;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    float velocidade = 10.0f;

    void Movimentacao() {

        // GetAxis são as cetas para a esquerda e direita ou A e D
        // Variavel = input.Tecla("Orientação") * Velocidade * Tempo.deltaTime
        float px = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;

        float pz = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;

        float py = Input.GetAxis("Jump") * velocidade * Time.deltaTime;

        // transform.Translate(velocidade X, velocidade Y, velocidade Z);
        // transform.Translate é a sitaxe para para mudar a posição do objeto
        transform.Translate(px, py, pz);

    }

    void Olhar()
    {
        float ry = Input.GetAxis("Mouse X") * velocidade;
        float rx = Input.GetAxis("Mouse Y") * velocidade;

        transform.Rotate(rx, ry, 0.0f);
    }

    void Update()
    {

        Movimentacao();
        Olhar();

    }
}
