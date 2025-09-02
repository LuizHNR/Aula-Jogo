using UnityEngine;

public class ExemploFuncao3 : MonoBehaviour
{
    /*
       Saida       Entrada
        Retorno nome( Argumento ){
            
        }
      
     */

    bool Media(float a, float b, float c)
    {
        if ((a+b+c)/3 >= 6)
        {
            return true;
        }

        return false;
    }


    void Start()
    {
        print(Media(5.0f, 3.0f, 10.0f));
        
    }


}
