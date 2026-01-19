using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CorrotinaExemplo : MonoBehaviour
{
    // Criacao de uma variavel inteira chamada N
    int n;
    IEnumerator Aleatorio()
    {
        // N recebe um valor aleatorio entre 0 e 100
        n = Random.Range(0, 100);
        // Funcao fica em pausa por 5 segundos
        yield return new WaitForSeconds(5.0f);
        // Valor de N e exbido no console
        print(n);
    }

    private void Start()
    {
        // Chamada da coroutine
        StartCoroutine(Aleatorio());
    }
}