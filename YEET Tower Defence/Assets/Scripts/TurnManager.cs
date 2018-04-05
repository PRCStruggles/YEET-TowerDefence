using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public Player player1;
    public Player player2;

    private int gameState;

    public Button button;
    public Text text;

    private static Player HisTurn;
    void Start()
    {
        gameState = 0;
        SwitchTurn();
    }

    public void SwitchTurn()
    {
        if (gameState == 2)
        {
            gameState = 0;
        }
        else
        {
            gameState++;
        }


        switch (gameState)
        {
            case 0: //playingphase
                HisTurn = null;
                button.enabled = false;
                break;

            case 1: //player 1 turn
                HisTurn = player1;
                button.enabled = true;

                break;

            case 2: //player 2 turn
                HisTurn = player2;
                break;

            default:
                break;
        }


    }

    public static Player GetPlayerWithTurn()
    {
        return HisTurn;
    }
}
