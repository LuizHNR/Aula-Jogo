using UnityEngine;

public class EstruturaComposta : MonoBehaviour
{

    /*
         Estrutura de condição - composta:

        if([condição]){
            instruções a; [TRUE]
        }else{
            instruções b; [FALSE]
        }

     */

    int vidas = 3;
    void Start()
    {
        if ( vidas > 0 )
        {
            print("Em jogo");
        }else{
            print("Fim de jogo");
        }
    }

}
