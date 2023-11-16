using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorBehaviour : MonoBehaviour
{

    [SerializeField] private float xOffset;
    [SerializeField] private GameObject indicator;

    private void OnEnable()
    {
        ButtonInteractionsController.OnDrag += MoveIndicator;
        ButtonInteractionsController.OnLeave += HideIndicator;
        ButtonInteractionsController.OnSelected += MoveIndicator;
    }

    private void OnDisable()
    {
        ButtonInteractionsController.OnDrag -= MoveIndicator;
        ButtonInteractionsController.OnLeave += HideIndicator;
        ButtonInteractionsController.OnSelected -= MoveIndicator;
    }

    private void MoveIndicator(GameObject selectedButton)
    {
        indicator.gameObject.SetActive(true);
        transform.position = new Vector2(selectedButton.transform.position.x  + xOffset, selectedButton.transform.position.y);
    }

    public void HideIndicator()
    {
        indicator.gameObject.SetActive(false);
    }
}
