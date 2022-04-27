using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public GameData gameData;
    public bool isGameActive;
    private int enemySpawnRate;
    private int enemiesSpawned;
    private int enemiesRemaining;
    private int score;
    private int difficulty = 1;
    private int baseDifficultyIncrease;
    private int wave;
    public float timeElapsed = 0;
    bool counterIsRunning;

    private int powerUpSpawnRate;

    
    public List<GameObject> enemyPrefabs;
    public List<GameObject> powerUpPrefabs;
    
    // Start the game, remove title screen, reset score, and adjust spawnRate based on difficulty button clicked
    private void Start()
    {
        StartGame();
    }

    public void StartGame()//(int difficulty)
    {
        enemySpawnRate = (gameData.enemySpawnRate / difficulty);
        powerUpSpawnRate = (gameData.powerUpSpawnRate / difficulty);
        
        isGameActive = true;
        
        StartCoroutine(SpawnPowerUp());
        StartCoroutine(SpawnEnemy());
        score = 0;
        wave = 1;
        enemiesSpawned = 0;
        //UpdateScore(0);
        counterIsRunning = true;
        timeElapsed = 0;

        //titleScreen.SetActive(false);
    }
    
    private void Update()
    {

        if (counterIsRunning)
        {
            if (enemiesRemaining > 0)
            {
                timeElapsed += Time.deltaTime;
                //DisplayTime(timeElapsed);
                //DisplayEnemyCount(enemiesRemaining);
            }
            else
            {
                PauseForNextWave();
                enemiesRemaining = 0;
                counterIsRunning = false;
            }
        }
    }

    private void PauseForNextWave()
    {
        StopCoroutine(SpawnEnemy());
        StopCoroutine(SpawnPowerUp());
    }
    /*
    // Update score with value from enemy killed
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }*/
    
    // While game is active spawn a random target
    IEnumerator SpawnPowerUp()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(powerUpSpawnRate);
            int index = Random.Range(0, powerUpPrefabs.Count);

            if (isGameActive)
            {
                Instantiate(powerUpPrefabs[index], RandomSpawnPosition(), powerUpPrefabs[index].transform.rotation);
            }

        }
    }
 
    // While game is active spawn a random enemy
    // ReSharper disable Unity.PerformanceAnalysis
    IEnumerator SpawnEnemy()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(enemySpawnRate);
            int index = Random.Range(0, enemyPrefabs.Count);

            if (isGameActive && enemiesSpawned <= (baseDifficultyIncrease + wave + difficulty))
            {
                Instantiate(enemyPrefabs[index], RandomSpawnPosition(), enemyPrefabs[index].transform.rotation);
                enemiesSpawned += 1;
                Debug.Log("Total enemies spawned "+ enemiesSpawned);
            }
            if (isGameActive && enemiesRemaining == 0)
            {
                Instantiate(enemyPrefabs[index], RandomSpawnPosition(), enemyPrefabs[index].transform.rotation);
                enemiesSpawned += 1;
                Debug.Log("Total enemies spawned "+ enemiesSpawned);
            }

        }
    }
    
    // Generate a random spawn position
    Vector3 RandomSpawnPosition()
    {
        float spawnPosX = Random.Range(-45,45);
        float spawnPosZ = Random.Range(-45,45);

        Vector3 spawnPosition = new Vector3(spawnPosX,0, spawnPosZ);
        return spawnPosition;

    }
    
    // Stop game, bring up game over text and restart button
    public void GameOver()
    {
        counterIsRunning = false;
        //DisplayTime(-1);
        //gameOverText.gameObject.SetActive(true);
        //restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }
    // Restart game by reloading the scene
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    /*
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI gameOverText;
    public GameObject titleScreen;
    public Button restartButton;

    public void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = "Time Remaining: " + (string.Format("{0:00}:{1:00}", minutes, seconds));
    }*/
}