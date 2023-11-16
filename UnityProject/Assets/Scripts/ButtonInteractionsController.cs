using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ButtonInteractionsController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler
{
    public static event Action<GameObject> OnDrag;
    public static event Action OnLeave;
    public static event Action<GameObject> OnSelected;

    public void OnSelect(BaseEventData eventData)
    {
        OnSelected?.Invoke(this.gameObject);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        OnDrag?.Invoke(this.gameObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnLeave?.Invoke();
    }
}
