using UnityEngine;

public class Rotacao : MonoBehaviour
{

    void Start()
    {
        //   rotation = eulerAngles, porem vai receber as intruções em graus
        transform.eulerAngles = new Vector3(0.0f, 45.0f, 0.0f);

    }


    void Update()
    {
        if (Input.anyKeyDown)
        {
            transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
        }
        
    }
}
