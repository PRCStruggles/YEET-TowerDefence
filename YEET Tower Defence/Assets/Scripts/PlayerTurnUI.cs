using UnityEngine;
using UnityEngine.UI;


public class PlayerTurnUI : MonoBehaviour
{
    public Text playerTurnText;

    void Update()
    {
        if (GameManager.Building)
        {
             playerTurnText.text = "Player " + TurnManager.GetPlayerWithTurn().ID.ToString() + "'s turn";
           // playerTurnText.text = "building";
        }
        else if (!GameManager.Building)
        {
            playerTurnText.text = "not building";
        }
    }
}