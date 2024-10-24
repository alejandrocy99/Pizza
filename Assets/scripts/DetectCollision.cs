using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private GameManager gameManager;
    int puntuacion = 1;
    // Start is called before the first frame update
    void Start()
    {
       gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
            

            if(gameObject.CompareTag("pollo")){
            gameManager.UpdateScore(puntuacion);
            Destroy(other.gameObject);
            Destroy(gameObject);

            }if(gameObject.CompareTag("perro")){
            gameManager.UpdateScore(puntuacion);
            Destroy(other.gameObject);
            Destroy(gameObject);
            }if(gameObject.CompareTag("cabra")){
            gameManager.UpdateScore(puntuacion);
            Destroy(other.gameObject);
            Destroy(gameObject);
            }
            
    }

}
