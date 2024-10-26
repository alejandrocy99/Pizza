using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    private int score;
    public GameObject gameOverUi;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
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

     public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

     public void TriggerGameOver(){
        gameOverUi.SetActive(true);
    }
}






  