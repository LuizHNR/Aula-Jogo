using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CorrotinaExemplo2 : MonoBehaviour
{
    // Variavel para contagem  dos ciclos
    int vezes;

    IEnumerator Estados()
    {
        // Registra 
        vezes++;
        print("Ciclo:" + vezes.ToString());


        // Estado parado
        print("Estou parado.");
        yield return new WaitForSeconds(3.0f);


        // Estado andando
        print("Estou andando.");
        yield return new WaitForSeconds(10.0f);



        // Repete o ciclo se ainda nao executou 3X
        if (vezes < 3)
        {
            StartCoroutine(Estados());
        }
        else
        {
            print("Fim.");
        }
    }
    // Start executa sempre ao iniciar o script uma única vez
    void Start()
    {
        // Inicia a execução da corrotina
        StartCoroutine(Estados());
    }
}