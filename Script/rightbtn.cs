using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class rightbtn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {

        playermovement.right = true;
        playermovement.left = false;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        playermovement.right = false;
    }


}
