using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
 
    private float maxf = 36f;
    private float minf = -20f;

    // Update is called once per frame
    void Update()
    {
         Vector3 posicion = transform.position;
         
         if ( posicion.z > maxf) Destroy(gameObject);
         if (posicion.z < minf){
            Destroy(gameObject);
            Debug.Log("game over");
            Time.timeScale = 0f;
         } 
    }
}
