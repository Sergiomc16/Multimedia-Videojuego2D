using UnityEngine;

public class SeguirCamara : MonoBehaviour
{
    //objeto que la camara seguira (nuestro jugador)
    public Transform jugador;

    public float offsetY = 0f;

    void LateUpdate()
    {
        if (jugador != null)
        {
            //guardamos la posición actual de la camara
            //ESTA PARA VERTICAL, HAY QUE CAMBIARLO A HORIZONTAL (EJE X)
            Vector3 posicionCamara = transform.position;

            posicionCamara.y = jugador.position.y + offsetY;

            transform.position = posicionCamara;
        }
    }
    
}
