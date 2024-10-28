using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;


public class SpawManager : MonoBehaviour
{
    float prueba = 1;
    private GameManager gameManager;

    public GameObject[] animalPrefabs;




    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        Debug.Log("timeSpaw[" + gameManager.timeSpaw + "]");
        InvokeRepeating("SpawnRandomAnimal", 2.0f, 1.5f / prueba);
    }



    public void SpawnRandomAnimal()
    {
        int randomIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 posicion = new Vector3(Random.Range(-25f, 25f), 0, 32);
        transform.localScale = gameManager.nuevaEscala;
        GameObject animal = Instantiate(animalPrefabs[randomIndex], posicion, animalPrefabs[randomIndex].transform.rotation);
        if(animal.CompareTag("pollo")){
            animal.transform.localScale = new Vector3(1f,1f,1f);
        }else{
            animal.transform.localScale = gameManager.nuevaEscala;
        }
        
    }

    public void setSpawn()
    {
        CancelInvoke("SpawnRandomAnimal");
        prueba = 1.5f / gameManager.timeSpaw;
        Debug.Log("PRUEBA [" + prueba + "]");
        InvokeRepeating("SpawnRandomAnimal", 1.5f, prueba);
    }
}


