using UnityEngine;

public class ExemploFor : MonoBehaviour
{

    /*
         Sintaxe:

        for( int i=0; [condi��o]; [incrementador/decrementador] ){
            instru��es;
        }

     */

    void Start()
    {
        int numero = 7;

        for (int n = 0; n <= 10; n++) { 

            print(numero + "X" + n + "=" + (numero*n));

        }
    }

}
