using UnityEngine;

public class ExemploDoWhile : MonoBehaviour
{

    /*
     
        Explica��o
          -> Ele executa uma vez a condi��o, porem se for (true) o while ele continua repetindo at� que se torne (false)
      
         Sintaxe:

        do{
            comando 1;
               
        }while( [condi��o] );

     */


    /*
        
     
    
     */

    void Start()
    {
        int n = 0;

        do
        {
            print(n);
            n++; // para subtrair � n--;

        } while (n < 10);

        print("FIM");


        // teste

        int numero = 10;

        while (numero > 0) {

            if ( numero % 2 != 0 )
            {
                print($"O numero {numero} � primo");
            }
            else
            {
                print($"O numero {numero} n�o � primo");
            }

            numero--;
        }

        print("Fim teste");

    }

}
