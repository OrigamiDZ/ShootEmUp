using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject[] hazards;
    [SerializeField]
    private GameObject herb;

    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public Text scoreText;
    public Text restartText;
    public Text gameOverText;

    private bool gameOver;
    private bool restart;
    private int score;

    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
        StartCoroutine(SpawnHerbs());
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
        restartText.text = "Press 'R' for Restart or 'B' for Back";
        restart = true;
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
    
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                break;
            }

            hazardCount++;
            spawnWait = spawnWait * 0.9f;

        }

    }

    IEnumerator SpawnHerbs()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {
            Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(herb, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnWait);
            
            if (gameOver)
            {
                break;
            }

        }
    }

    void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Scene activeScene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(activeScene.name);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

}
