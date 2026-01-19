using System.Collections;
using UnityEngine;

public class ExemploCorrotina : MonoBehaviour
{
    /*
     Relembrendo Função
    
    retorno nomeDaFuncao ( [parametros] ){
        // corpo da função
    }

    -------------------------------------------------------

    E assim chama a função

    nomeDaFuncao();

     */



    //Vai gerar um contador (Corrotina é uma função async)
    IEnumerator Exemplo()
    {
        print("Inicio da Corrotina");

        // retornar com um tempo de espera de 2 segundos
        yield return new WaitForSeconds(2.0f);

        // Então no caso ela vai esperar 2 segundos após ser chamada e executar esse print

        print("Olá, Mundo!");
    }




    void Start()
    {
        // Essa é a forma de chamar a função asyncrona
        StartCoroutine(Exemplo());
        
    }



    // Update is called once per frame
    void Update()
    {
        print("update");
        
    }
}
