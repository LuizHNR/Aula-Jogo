using UnityEngine;

public class ExemploWhile : MonoBehaviour
{
    /*
         Sintaxe:

        int a = 0;

               [condição]
        while(   a < 10   ){
            instruções;
        }

     */

    void Start()
    {

        int n = 0;

        while (n < 100)
        {
           print(n);

           n++; // n = n+1
        }

        print("FIM");
        
    }

}
