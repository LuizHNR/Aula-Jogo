using System.Collections;
using UnityEngine;

public class MaisExemplo : MonoBehaviour
{
    // GameObject é qualquer elemento no jogo
    public GameObject estrela;

    Vector3 p;

    IEnumerator Start()
    {
        p = new Vector3(Random.Range(-5.0f, 5.0f), 0.0f, 0.0f);
        // transform.rotation é o estado original de rotação do objeto que no caso é zero
        Instantiate(estrela, p, transform.rotation);

        yield return new WaitForSeconds(3.0f);

        p = new Vector3(Random.Range(-5.0f, 5.0f), 0.0f, 0.0f);
        Instantiate(estrela, p, transform.rotation);

        yield return new WaitForSeconds(1.0f);
        print("Fim");
    }


}
