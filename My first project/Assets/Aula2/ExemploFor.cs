using UnityEngine;

public class ExemploFor : MonoBehaviour
{

    /*
         Sintaxe:

        for( int i=0; [condição]; [incrementador/decrementador] ){
            instruções;
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
