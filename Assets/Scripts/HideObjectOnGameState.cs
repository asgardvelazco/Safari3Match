using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObjectOnGameState : MonoBehaviour
{
    public GameObject target;
    public GameManager.GameState showOnstate;

    // Start is called before the first frame update
    void Start()
    {
        target.SetActive(showOnstate == GameManager.Instance.gameState);
/*      La línea anterior elimina la necesidad del if/else
        if (showOnstate == GameManager.Instance.gameState)
        {
            target.SetActive(true);
        }
        else
        {
            target.SetActive(false);
        }*/
            GameManager.Instance.OnGameStateUpdated.AddListener(GameStateUpdated);
    }

    private void GameStateUpdated(GameManager.GameState newState)
    {
        target.SetActive(showOnstate == GameManager.Instance.gameState);
    }

}
