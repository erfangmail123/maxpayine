using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;
    public int enemiesPerWave = 3;
    public float timeBetweenWaves = 5f;
    private int waveNumber = 0;

    void Start()
    {
        InvokeRepeating("SpawnWave", 2f, timeBetweenWaves);
    }

    void SpawnWave()
    {
        waveNumber++;
        int enemyCount = enemiesPerWave + waveNumber; // افزایش سختی با هر موج

        for (int i = 0; i < enemyCount; i++)
        {
            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }

        Debug.Log("Wave " + waveNumber + " spawned with " + enemyCount + " enemies.");
    }
}
