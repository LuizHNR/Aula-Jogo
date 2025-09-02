using UnityEngine;

public class ExemploFuncao2 : MonoBehaviour
{

    /*
       Saida       Entrada
        Retorno nome(){
            
        }
     
     
     */

    void Start()
    {
        Somar(5, 3);
    }

    void Somar(int a, int b)
    {
        int r = a + b;
        print($"{a} + {b} = {r}");
    }

}
