using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineBehaviour : MonoBehaviour
{

    [SerializeField] private float impulse;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetTrigger("impulse");
        collision.gameObject.GetComponent<MovementBehaviour>().Jump(impulse);
    }
}
