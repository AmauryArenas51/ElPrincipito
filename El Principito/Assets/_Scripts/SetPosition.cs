using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.EventSystems;

public class SetPosition : MonoBehaviour, IDropHandler
{

    private DragHandler item;
    
    public GameObject objectPositionable;

    private void Start()
    {
        item = GetComponent<DragHandler>();

        objectPositionable = GetComponent<GameObject>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null || item.drop)
        {
            OnSetPosition(eventData);
        }
    }

    public void OnSetPosition(PointerEventData eventData)
    {
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
            GetComponent<RectTransform>().anchoredPosition;
    }
}
