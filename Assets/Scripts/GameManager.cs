using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameplayStatus { Explore, Dialogue, Puzzle, Menu }
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private GameplayStatus currentGameplayStatus;

    public void SetCurrentGameplayStatus(GameplayStatus _status)
    {
        currentGameplayStatus = _status;
    }
}
