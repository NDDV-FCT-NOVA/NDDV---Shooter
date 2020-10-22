﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag($"Target"))
        {
            Debug.Log("YOU WIN!");
            GameController.EndGame();
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
