using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public List<GameObject> targets;//Similiar to an array
    private float spawnRate = 1.0f;
    private int score;
    public TextMeshProUGUI scoreText;//needs using TMPro; 
    public TextMeshProUGUI gameOverText;
    public Button restartButton;//needs using UnityEngine.UI;
    public GameObject titleScreen;

    private void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void StartGame(int difficulty)
    {
        isGameActive = true;//Setting the game to true has to be above the coroutine or it will never spawn anything
        
        StartCoroutine(SpawnTarget());
        score = 0;
        spawnRate /= difficulty;//sets the spawn rate of the objects to 1.0f/ difficulty defined on the button
        UpdateScore(0);
        
        titleScreen.gameObject.SetActive(false);
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//gets active scene name 
    }
}