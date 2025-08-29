using UnityEngine;

public class ExemploEncadeada : MonoBehaviour
{

    // porta = false esta fechada / true aberta
    bool porta = true;

    // public faz um input no inspector do Unity
    public int moedas;

    void Start()
    {

        if (porta == true)
        {

            print("Porta esta aberta.");

            if (moedas >= 100)
            {
                print("Artefato coletado");
            }
            else
            {
                print("Quantidade de moedas insuficiente!");
            }

        }
        else
        {
            print("Porta esta fechada.");
        }       

    }

}
