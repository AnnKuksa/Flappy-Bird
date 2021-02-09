using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float velocity = 1; // скорость птички
    private Rigidbody2D rb; // птичка
    public GameManager gameManager;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // если нажимать на кнопку
        {
            rb.velocity = Vector2.up * velocity; // птичка летит вверх
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GamOver();
    }
}
