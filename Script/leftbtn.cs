using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class leftbtn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        playermovement.left = true;
        playermovement.right = false;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        playermovement.left = false;
    }


}

