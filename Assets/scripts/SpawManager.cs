using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawManager : MonoBehaviour
{

    public GameObject [] animalPrefabs;

    
        

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",2.0f,1.5f);
        
    }

    public void SpawnRandomAnimal(){
        int randomIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 posicion = new Vector3(Random.Range(-25f,25f),0,32);
        Instantiate(animalPrefabs[randomIndex],posicion,animalPrefabs[randomIndex].transform.rotation);
    }
}


