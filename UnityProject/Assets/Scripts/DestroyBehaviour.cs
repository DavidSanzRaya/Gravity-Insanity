using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehaviour : MonoBehaviour
{
    public GameObject FX;
    public void DestroyObject()
    {
        if (FX != null)
        {
            Instantiate(FX, transform.position, Quaternion.identity);
        }

        Destroy(this.gameObject);
    }

    public void DeactivateObject()
    {
        if (FX != null)
        {
            Instantiate(FX, transform.position, Quaternion.identity);
        }
        gameObject.SetActive(false);
    }
}
