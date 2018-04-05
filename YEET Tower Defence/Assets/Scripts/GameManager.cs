using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool gameEnded = false;

    public GameObject gameOverUI;


	void Update ()
    {
        #region TestGameOverButton
        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }
        #endregion

        if (gameEnded)
        {
            return;
        }
	}

    void EndGame()
    {
        gameEnded = true;
        gameOverUI.SetActive(true);
    }

}
