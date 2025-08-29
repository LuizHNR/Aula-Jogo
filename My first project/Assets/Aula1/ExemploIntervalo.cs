using UnityEngine;

public class ExemploIntervalo : MonoBehaviour
{

    /*
         Sintaxe:

        && = E
        || = OU

        if([condi��o] [operador] [condicao]){
            instru��es;
        }

     */

    int a = 10;
    int b = 5;


    void Start()
    {


        // Condi��o com operadores
        if (a >= 10 && b == 5)
        {
            print("condi��o satisfeita.");
        }

        // Intervalo de valor
        if (a >=0 || a <= 10)
        {
            print("Dentro do intervalo.");
        }

        print("FIM.");
    }


}
