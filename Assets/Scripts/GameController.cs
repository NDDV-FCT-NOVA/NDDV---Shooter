using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public delegate void GameEnd();
    public static event GameEnd GameEnded;

    public static void EndGame()
    {
        GameEnded?.Invoke();
    }
}
