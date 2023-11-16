using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    

    private void Start()
    {
        TryGetComponent<Rigidbody2D>(out rb);
    }

    public void Move2D(Vector3 dir)
    {
        dir.Normalize();
        transform.position += dir * speed * Time.deltaTime;
    }

    public void MoveRB2D(Vector2 dir)
    {
        dir.Normalize();
        rb.velocity = new Vector2(dir.x * speed, rb.velocity.y);
    }

    public void Flip()
    {
        rb.gravityScale *= -1;
        rb.velocity = new Vector2(0, 0);

        gameObject.transform.Rotate(180, 0, 0);
    }

    public void Rotate(float angularSpeed)
    {
        rb.angularVelocity = angularSpeed;
    }

    public void Jump(float jumpForce)
    {
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public float GetSpeed()
    {
        return this.speed;
    }

    public void MultiplySpeed(float speed)
    {
        this.speed *= speed; 
    }

}
