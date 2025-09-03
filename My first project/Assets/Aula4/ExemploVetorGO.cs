using UnityEngine;

public class ExemploVetorGO : MonoBehaviour
{
    // para poder atribuir externamente
    // public int a;

    public GameObject[] armas;

    void Start()
    {
        // instacia
        Instantiate(armas[Random.Range(0,2)]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
