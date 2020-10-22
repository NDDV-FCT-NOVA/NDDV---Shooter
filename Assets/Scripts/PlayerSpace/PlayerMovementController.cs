using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float movSpeed = 5f;
    
    public Vector2 MovInput
    {
        set => movInput = value;
    }
    private Vector2 movInput;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        // rb.isKinematic = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PerformMovement();
    }

    private void PerformMovement()
    {
        rb.velocity = movInput * movSpeed;
    }
}
