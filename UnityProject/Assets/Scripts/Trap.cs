using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Trap : MonoBehaviour
{
    [SerializeField] private GameObject path;
    private Transform[] route;
    private int point;
    private MovementBehaviour mvb;

    private void Awake()
    {
        route = path.GetComponentsInChildren<Transform>();
        mvb = GetComponent<MovementBehaviour>();
        point = 1;
        transform.position = route[point].transform.position;
    }

    private void Update()
    {
        mvb.Move2D(route[point].transform.position - transform.position);

        if (Vector2.Distance(transform.position, route[point].transform.position) < 0.1)
        {
            point++;

            if(point == route.Length)
            {
                point = 1;
            }
        }
    }
}
