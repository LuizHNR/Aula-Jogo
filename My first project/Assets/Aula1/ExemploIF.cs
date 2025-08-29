using UnityEngine;

public class ExemploIF : MonoBehaviour
{

    /*
         Sintaxe:

        if([condição]){
            instruções;
        }

     */

    int a = 0;

    void Update()
    {
        if (a == 5)
        {
            print("a é maior que 3");
        }

        a = a + 1;

        print("FIM.");
    }
}
