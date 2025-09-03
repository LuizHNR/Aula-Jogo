using UnityEngine;

public class ExemploVetor : MonoBehaviour
{
    // Isso é um vetor
    int[] a = new int[4];


    void Start()
    {
        a[0] = 10;
        a[1] = 50;
        a[2] = 3;
        a[3] = 4;


        for (int i =0; i < a.Length; i++)
        {
            print(a[i]);
        }
        
    }

    
}
