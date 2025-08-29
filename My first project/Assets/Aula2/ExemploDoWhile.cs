using UnityEngine;

public class ExemploDoWhile : MonoBehaviour
{

    /*
     
        Explicação
          -> Ele executa uma vez a condição, porem se for (true) o while ele continua repetindo até que se torne (false)
      
         Sintaxe:

        do{
            comando 1;
               
        }while( [condição] );

     */


    /*
        
     
    
     */

    void Start()
    {
        int n = 0;

        do
        {
            print(n);
            n++; // para subtrair é n--;

        } while (n < 10);

        print("FIM");


        // teste

        int numero = 10;

        while (numero > 0) {

            if ( numero % 2 != 0 )
            {
                print($"O numero {numero} é primo");
            }
            else
            {
                print($"O numero {numero} não é primo");
            }

            numero--;
        }

        print("Fim teste");

    }

}
