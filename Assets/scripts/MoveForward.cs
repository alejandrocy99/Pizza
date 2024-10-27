using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFord : MonoBehaviour
{
    public float speed;
    private GameManager gameManager;

       void Start(){
        gameManager = FindObjectOfType<GameManager>();
    }

  
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * gameManager.speed*Time.deltaTime);
        
    }

   
}


