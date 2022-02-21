using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float JumpingForce, MovementSpeed;
    public Rigidbody2D rigid2D;
    public bool jumping;

    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        MovementSpeed = 80f;
        JumpingForce = 40f;
        jumping = true;
    }

    // Update is called once per frame
    void Update()
    {
        float MovX = Input.GetAxisRaw("Horizontal");
        float MovY = Input.GetAxisRaw("Vertical");

        if(MovX != 0){
            rigid2D.velocity = new Vector2(MovementSpeed * MovX, rigid2D.velocity.y);
        }

        if(MovY == 1 && !jumping){
            rigid2D.velocity = new Vector2(rigid2D.velocity.x, JumpingForce);
            jumping = true;
        }

    }

    void onCollisionEnter2D(Collision2D collision){
        jumping = false;
    }
}
