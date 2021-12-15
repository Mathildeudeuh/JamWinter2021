using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class Move2D : MonoBehaviour
{
    public float speed;

    [HideInInspector] public Vector2 direction;

    private Rigidbody2D rb2D;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    //private void FixeUpdate()
    //{
    // Move();
    //}

    private void Update()
    {
        var directionXY = new Vector2(direction.x, direction.y);
        rb2D.velocity = directionXY.normalized * speed;
    }
    public void Move(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
}