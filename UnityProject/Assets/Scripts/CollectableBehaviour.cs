using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollectableBehaviour : MonoBehaviour
{
    public static event Action OnCollected;

    public void AddCollected()
    {
        OnCollected?.Invoke();
    }
}
