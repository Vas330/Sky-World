using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{

   
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public Joystick joystick;
    public float health;
  



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        Vector2 moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);
        moveVelocity = moveInput.normalized * speed;
       
    }



    void FixedUpdate() {
        Vector3 endPosition = rb.position + moveVelocity * Time.fixedDeltaTime;
        if (endPosition.x > 4.7f) endPosition.x = 4.7f;
        if (endPosition.x < -4.7f) endPosition.x = -4.7f;
        if (endPosition.y < 0.7f) endPosition.y = 0.7f;
        if (endPosition.y > 5.5f) endPosition.y = 5.5f;
        
        rb.MovePosition(endPosition);
    }

    public void ChangeHealth(int healthValue)
    {
        health += healthValue;
    }
}