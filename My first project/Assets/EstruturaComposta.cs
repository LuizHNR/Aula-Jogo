using UnityEngine;

public class EstruturaComposta : MonoBehaviour
{

    /*
         Estrutura de condi��o - composta:

        if([condi��o]){
            instru��es a; [TRUE]
        }else{
            instru��es b; [FALSE]
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
