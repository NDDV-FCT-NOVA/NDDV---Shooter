using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScreen : MonoBehaviour
{
    [SerializeField] private GameObject endGameObjects;

    private GameObject _instantiatedEndGameObjects;
    
    // Start is called before the first frame update

    private void Awake()
    {
        SceneManager.sceneLoaded += NewLevel;
    }

    private void Start()
    {
        
    }

    public void NewLevel(Scene arg0, LoadSceneMode loadSceneMode)
    {
        Transform canvas = GameObject.Find("Canvas").GetComponent<Transform>();
        _instantiatedEndGameObjects = Instantiate(endGameObjects, canvas);
        _instantiatedEndGameObjects.SetActive(false);
    }
    
    private void OnEnable()
    {
        GameController.GameEnded += ShowEndScreen;
    }

    private void OnDisable()
    {
        GameController.GameEnded -= ShowEndScreen;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowEndScreen()
    {
        endGameObjects.SetActive(true);    
    }
}
