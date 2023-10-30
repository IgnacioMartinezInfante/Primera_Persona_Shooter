using UnityEngine;

public class destruiresmeraldas : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("jugador"))
        {
            Esmeraldascontador contaresmeraldas = FindObjectOfType<Esmeraldascontador>();
            if (contaresmeraldas != null)
            {
                contaresmeraldas.Increasecontaresmeraldas(); // Aumenta el contador de monedas.
            }

            Destroy(gameObject); // Destruye la moneda.
        }
    }
}
