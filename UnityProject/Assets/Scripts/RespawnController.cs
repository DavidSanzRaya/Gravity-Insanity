using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour
{

    private Vector2 respawnPosition;
    private MovementBehaviour mvb;
    private Rigidbody2D rb;

    private void Awake()
    {
        TryGetComponent<MovementBehaviour>(out mvb);
        rb = GetComponent<Rigidbody2D>();
        respawnPosition = this.transform.position;
    }

    public void OnReachedCheckPoint(Vector2 position)
    {
        respawnPosition = position;
    }

    public void Respawn()
    {
        if(rb.gravityScale < 0)
        {
            mvb.Flip();
        }
   
        this.transform.position = respawnPosition;
        this.gameObject.SetActive(true);
    }
}
