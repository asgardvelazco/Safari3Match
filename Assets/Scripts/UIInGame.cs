using System;
using System.Collections;
using UnityEngine;

public class UIInGame : MonoBehaviour
{
    public void PauseButtonPressed()
    {
        GameManager.Instance.Pause();
    }
}
