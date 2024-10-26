using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private GameManager gameManager;
    int puntuacion = 1;

    // Start se llama antes del primer frame
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (gameManager == null)
        {
            Debug.LogError("GameManager no encontrado. Asegúrate de que el objeto GameManager existe en la escena y tiene el componente GameManager.");
        }
    }

    // Método que se llama cuando ocurre una colisión
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("pollo") || gameObject.CompareTag("perro") || gameObject.CompareTag("cabra"))
        {
            Debug.Log("Colisión detectada con: " + other.gameObject.name);
            
            gameManager.UpdateScore(puntuacion);
            Debug.Log("Puntuación actualizada: " + puntuacion);
            
            Destroy(other.gameObject);
            Debug.Log("Objeto colisionado destruido.");

            Destroy(gameObject);
            Debug.Log("Objeto actual destruido.");
        }
    }
}
