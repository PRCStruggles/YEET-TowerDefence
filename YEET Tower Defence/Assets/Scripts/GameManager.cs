using UnityEngine;

public class GameManager : MonoBehaviour
{

    private bool gameEnded = false;
    public WaveSpawner waveSpawner;


	void Update ()
    {
        if (gameEnded)
        {
            return;
        }
	}

    void EndGame()
    {
        gameEnded = true;
        Debug.Log("Game Over!");
    }

    public void startWave()
    {
        
    }
}
