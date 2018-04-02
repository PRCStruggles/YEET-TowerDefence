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
        if (GameManager.Building)
        {
            button.enabled = true;
            text.enabled = true;
            if (count++ % 2 == 0)
            {
                HisTurn = player1;
            }

            else
            {
                HisTurn = player2;
            }
        }
        else
        {
            text.enabled = false;
            button.enabled = false;
        }
    }

    public static Player GetPlayerWithTurn()
    {
        return HisTurn;
    }
}
