using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.Runtime.CompilerServices;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    private int score;
    public GameObject gameOverUI;
     public GameObject gameOverUI2;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
        score = 0;
        Time.timeScale = 0f;

        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int puntuacion) {
        score = score + puntuacion;
        scoreText.text = "puntuacion: " + score;
    }
    public void TriggerGameOver(){
        gameOverUI.SetActive(true);
    }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

       public void HideGameOverUI()
    {
        gameOverUI2.SetActive(false);
    }

    public void EasyMode(){
        speed = 5f;
        HideGameOverUI(); 
        Time.timeScale = 1f;
    }
    public void MediumMode(){
        speed = 10f;
        HideGameOverUI(); 
        Time.timeScale = 1f;
    }
    public void HarMode(){
        speed = 15f;
        HideGameOverUI(); 
        Time.timeScale = 1f;
    }
}






  