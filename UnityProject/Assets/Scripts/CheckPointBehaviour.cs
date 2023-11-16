using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<RespawnController>().OnReachedCheckPoint(transform.position);
        GetComponent<Animator>().enabled = true;
    }
}
