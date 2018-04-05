using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public static int enemiesAlive = 0;

    public Wave[] waves;

    public Transform spawnPointP1;
    public Transform spawnPointP2;

    private int waveNumber = 0;

    public TurnManager manager;   
   
    public void Spawnwaver()
    {
        if (TurnManager.GetPlayerWithTurn() == null)
        {
            Debug.Log("kanker");
            StartCoroutine(SpawnWave());
        }
    }


    public IEnumerator SpawnWave()
    {
        Debug.Log("kanker 1");
        Wave wave = waves[waveNumber];
        Debug.Log("kanker 2");
        for (int i = 0; i < wave.count; i++)
        {
            SpawnEnemies(wave.enemyPrefab);
            yield return new WaitForSeconds(1f / wave.rate);
        }
        waveNumber++;
        Debug.Log("kanker 3 ");

        if (waveNumber == waves.Length)
        {
            enabled = false;
        }
        Debug.Log("kanker 4");
        yield return new WaitUntil(() => enemiesAlive <= 0);
        manager.SwitchTurn();
        Debug.Log("kanker 5");
    }

    public void SpawnEnemies(GameObject enemy)
    {
        Debug.Log("kanker 5.5");
        Instantiate(enemy, spawnPointP1.position, spawnPointP2.rotation);
        enemiesAlive++;
        Debug.Log("kanker 6");
        Instantiate(enemy, spawnPointP2.position, spawnPointP2.rotation);
        enemiesAlive++;
        Debug.Log("kanker 7");
    }


}
