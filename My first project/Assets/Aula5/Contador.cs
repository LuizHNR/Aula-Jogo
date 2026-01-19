using System.Collections;
using UnityEngine;

public class Contador : MonoBehaviour
{

    int n = 0;

    IEnumerator Temporizador()
    {
        print("Tempo atual: " + n);
        yield return new WaitForSeconds(1.0f);
        n++;

        if(n <= 10)
        {
            StartCoroutine(Temporizador());
        }

    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Temporizador());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
