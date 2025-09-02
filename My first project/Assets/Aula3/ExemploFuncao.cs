using UnityEngine;

public class ExemploFuncao : MonoBehaviour
{
    /*
        Retorno nome(){
            
        }
     
     
     */



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Mensagem();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Mensagem();

        }
        
    }

// Sem retorno
    void Mensagem()
    {
        print("Iniciar");
        print("Preparando o jogo");
        print("Iniciando partida");
        print("Jogando...");

    }

}
