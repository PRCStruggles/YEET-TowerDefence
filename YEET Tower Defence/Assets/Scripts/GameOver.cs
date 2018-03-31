using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text winnerText;

    void OnEnable()
    {

        // WINNER TEXT NEEDED BUT NO PLAYERS YET
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}