using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public Player player1;
    public Player player2;

    public Button button;
    public Text text;

    private static Player HisTurn;

    private int count = 0;
    void Start()
    {
        SwitchTurn();
    }

    public void SwitchTurn()
    {
        Debug.Log("1");
        if (GameManager.Building)
        {
            Debug.Log("2");
            button.enabled = true;
            text.enabled = true;
            Debug.Log("3");
            if (count++ % 2 == 0)
            {
                Debug.Log("2eins");
                HisTurn = player1;
            }

            else
            {
                Debug.Log("zwei");
                HisTurn = player2;
                
            }
            Debug.Log("done");
        }
        else
        {
            Debug.Log("elsen");
            text.enabled = false;
            button.enabled = false;
        }
    }

    public static Player GetPlayerWithTurn()
    {
        return HisTurn;
    }
}
