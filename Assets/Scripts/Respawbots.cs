using UnityEngine;


public class Respawnobots : MonoBehaviour
{
    public GameObject[] controlenemigo; // Referencia al prefab de enemigo.
    public Vector3 posicionspawn;
    public float tiempoArranque;
    public float tiempoRepeticion;

    private void Start()
    {
        InvokeRepeating("SpawnEnemigos", tiempoArranque, tiempoRepeticion);
    }

    private void SpawnEnemigos()
    {
        int indicealeatorio = Random.Range(0, controlenemigo.Length);
        GameObject obstaculoaleatorio = controlenemigo[indicealeatorio];
        Instantiate(obstaculoaleatorio, posicionspawn, obstaculoaleatorio.transform.rotation);
    }
}
