using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScreen : MonoBehaviour
{
    [SerializeField] private GameObject endGameObjects;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
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
