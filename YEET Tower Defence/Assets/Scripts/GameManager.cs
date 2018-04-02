using UnityEngine;

public class GameManager : MonoBehaviour
{

    private bool gameEnded = false;
    public static bool Building = true;


	void Update ()
    {
        if (gameEnded)
        {
            return;
        }
	}

    void EndGame()
    {
        Building = false;
        gameEnded = true;
        Debug.Log("Game Over!");
    }
}
