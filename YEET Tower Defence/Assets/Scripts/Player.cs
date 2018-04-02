using UnityEngine;

public class Player : MonoBehaviour
{
    public string ID;
    public int Money;
    public int startMoney;

    void Start()
    {
        Money = startMoney;
    }
}
