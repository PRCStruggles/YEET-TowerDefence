using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool gameEnded;
    public GameObject gameOverUI;

    void Start()
    {
        gameEnded = false;
    }


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
