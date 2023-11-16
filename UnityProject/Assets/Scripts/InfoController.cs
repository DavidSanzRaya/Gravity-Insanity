using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InfoController : MonoBehaviour
{
    [SerializeField] private GameObject information;
    public UnityEvent OnApproach;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        information.SetActive(true);
        OnApproach.Invoke();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        information.SetActive(false);
    }

}
