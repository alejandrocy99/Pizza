using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFord : MonoBehaviour
{
    public float speed;
  
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed*Time.deltaTime);
        
    }
}