using UnityEngine;

public class ExemploVetor2 : MonoBehaviour
{
    // Isso é um vetor
    string[] nome = new string[] {"Ana", "Maria", "Nicole" };


    void Start()
    {
        // Trocar o conteudo de um vetor
        nome[1] = "Aline";

        foreach (string i in nome)
        {
            print(i);
        }
 
    }
}
