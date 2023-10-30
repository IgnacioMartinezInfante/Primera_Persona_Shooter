using UnityEngine;
using UnityEngine.UI;

public class Esmeraldascontador : MonoBehaviour
{
    public Text esmeraldastexto; // Referencia al objeto de texto que mostrará la cantidad de monedas.
    private int contaresmeraldas = 0; // Inicializamos el contador de monedas a 0.

    public GameObject VictoriaCanvas;

    // Método para aumentar la cantidad de monedas.

    private void Start()
    {
        Updateesmeraldastexto();
        VictoriaCanvas.SetActive(false);
    }
    public void Increasecontaresmeraldas()
    {
        contaresmeraldas++;
        Updateesmeraldastexto(); // Actualizamos el texto en pantalla.
    }

    // Método para actualizar el texto en pantalla con la cantidad actual de monedas.
    private void Updateesmeraldastexto()
    {
        esmeraldastexto.text = "Esmeraldas: " + contaresmeraldas.ToString() + "/3";
        if (contaresmeraldas >= 3)
        {
            Debug.Log("victoria");
            VictoriaCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
