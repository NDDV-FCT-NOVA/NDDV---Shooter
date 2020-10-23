using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    public delegate void GameEnd();
    public static event GameEnd GameEnded;

    private void Start()
    {
        
    }

    public static void EndGame()
    {
        GameEnded?.Invoke();
    }

    public static void NextScene()
    {
        int nextSceneIdx = Random.Range(0, SceneManager.sceneCountInBuildSettings);
        while (nextSceneIdx == SceneManager.GetActiveScene().buildIndex)
        {
            nextSceneIdx = Random.Range(0, SceneManager.sceneCountInBuildSettings);
        }
        SceneManager.LoadScene(nextSceneIdx);
    }
}
