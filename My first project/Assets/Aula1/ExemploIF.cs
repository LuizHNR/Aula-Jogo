using UnityEngine;

public class ExemploIF : MonoBehaviour
{

    /*
         Sintaxe:

        if([condi��o]){
            instru��es;
        }

     */

    int a = 0;

    void Update()
    {
        if (a == 5)
        {
            print("a � maior que 3");
        }

        a = a + 1;

        print("FIM.");
    }
}
