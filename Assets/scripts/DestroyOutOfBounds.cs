using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
 
    private float maxf = 36f;
    private float minf = -20f;
    private GameManager gameManager;

    void Start(){
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 posicion = transform.position;
         
         if ( posicion.z > maxf) Destroy(gameObject);
         if (posicion.z < minf){
            Destroy(gameObject);
            gameManager.TriggerGameOver();
            Time.timeScale = 0f;
         } 
    }
}
