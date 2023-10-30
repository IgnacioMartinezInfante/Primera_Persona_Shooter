using UnityEngine;


public class Muerte : MonoBehaviour
{
    public GameObject GameoverCanvas; // Referencia al Canvas de Game Over en la jerarqu�a

    private void Start()
    {
        // Configurar gameoverCanvas como falso al inicio del juego
        GameoverCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemigo")) // Cambia "ObjetoQueCausaGameover" por la etiqueta adecuada
        {
            // Mostrar el Canvas de Game Over y detener el tiempo
            GameoverCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    // M�todo para reiniciar la partida (llamado desde un bot�n en tu UI)
    public void RestartGame()
    {
        Time.timeScale = 1f; // Reanuda el tiempo (reinicia el juego)
        GameoverCanvas.SetActive(false); // Oculta el Canvas de Game Over
    }
}
