using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumBehaviour : MonoBehaviour
{
    private MovementBehaviour mvb;
    [SerializeField] private float angularSpeed;
    [SerializeField] private float leftAngle;
    [SerializeField] private float rightAngle;

    bool movingClockwise;
    
    void Start()
    {
        mvb = GetComponent<MovementBehaviour>();
        movingClockwise = true;
    }

    void Update()
    {
        Move();
    }

    public void ChangeMoveDir()
    {
        if (transform.rotation.z > rightAngle)
        {
            movingClockwise = false;
        }
        if (transform.rotation.z < leftAngle)
        {
            movingClockwise = true;
        }

    }

    public void Move()
    {
        ChangeMoveDir();

        if (movingClockwise)
        {
            mvb.Rotate(angularSpeed);
        }

        if (!movingClockwise)
        {
            mvb.Rotate(-angularSpeed);
        }
    }
}
