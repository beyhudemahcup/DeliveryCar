using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 250f;
    [SerializeField] private float moveSpeed = 20f;
    [SerializeField] private float slowSpeed = 10f;
    [SerializeField] private float boostSpeed = 30f;

    void Start()
    {
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "SpeedUp")
        {
            moveSpeed = boostSpeed;
        }
        else if (col.tag == "SpeedDown")
        {
            moveSpeed = slowSpeed;
        }
    }
}