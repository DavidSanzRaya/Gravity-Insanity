using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectablesController : MonoBehaviour
{
    private int currentCollectables;
    [SerializeField] private int totalCollectables;
    public UnityEvent OnAllCollected;

    private void Awake()
    {
        currentCollectables = 0;
    }

    private void OnEnable()
    {
        CollectableBehaviour.OnCollected += AddCollected;
    }

    private void OnDisble()
    {
        CollectableBehaviour.OnCollected -= AddCollected;
    }

    private void AddCollected()
    {
        currentCollectables++;

        if(currentCollectables == totalCollectables)
        {
            OnAllCollected.Invoke();
        }
    }
}
