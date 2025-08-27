using UnityEngine;

public class ExemploIntervalo : MonoBehaviour
{

    /*
         Sintaxe:

        && = E
        || = OU

        if([condição] [operador] [condicao]){
            instruções;
        }

     */

    int a = 10;
    int b = 5;


    void Start()
    {


        // Condição com operadores
        if (a >= 10 && b == 5)
        {
            print("condição satisfeita.");
        }

        // Intervalo de valor
        if (a >=0 || a <= 10)
        {
            print("Dentro do intervalo.");
        }

        print("FIM.");
    }


}
