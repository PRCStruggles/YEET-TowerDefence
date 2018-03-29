using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public void SetUiOn()
    {
        this.gameObject.SetActive(true);
    }

    public void SetUiOff()
    {
        gameObject.SetActive(false);
    }
}
