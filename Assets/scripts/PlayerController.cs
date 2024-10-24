using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float xMin = -25f , xMax = 25f;
     public float velocidad;

     public GameObject proyectil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //movimiento horizantal del jugador
        float move = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad;
        transform.Translate(move,0f,0f);

        


        Vector3 posicion = transform.position;
        posicion.x = Mathf.Clamp(posicion.x,xMin,xMax);
        transform.position =  posicion;

        if(Input.GetKeyDown(KeyCode.Space)){
                Instantiate(proyectil,posicion,Quaternion.identity);
        }
    }
}
