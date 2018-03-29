using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {

    public List<Player> Players;
    private int count = 0;
 


    // Use this for initialization
    void Start()
    {
        SwitchTurn();
    }

    public void SwitchTurn()
    {
        SetEveryOneOff();
        Players[count++ % Players.Count].SetUiOn();

    }

    public void SetEveryOneOff()
    {
        foreach (Player player in Players)
        {
            player.SetUiOff();
        }
    }

    public Player GetCurrentPlayer()
    {
        for (int i = 0; i < Players.Count; i++)
        {
            if (Players[i].isActiveAndEnabled)
            {
                return Players[i];
            }
        }

        return null;
    }
}
