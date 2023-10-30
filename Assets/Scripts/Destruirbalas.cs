using UnityEngine;

public class destruirbalas : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("jugador"))
        {
            contadorbalas contarbalas = FindObjectOfType<contadorbalas>();
            if (contarbalas != null)
            {
                contarbalas.Increasecontarbalas(); // Aumenta el contador de monedas.
            }

            Destroy(gameObject); // Destruye la moneda.
        }
    }
}
