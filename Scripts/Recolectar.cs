using UnityEngine;

public class Recolectar : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

    /*
    void OnCollisionEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PiedraAmarilla"))
        {
            Destroy(other.gameObject);
        }
    }
    */
}
