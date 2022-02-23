using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Btn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Для того чтобы выбрать и подсветить кпопку в UI элементе и EventSystem
    public void OnPointerDown(PointerEventData eventData)
    {
        transform.position = new Vector2(transform.position.x, transform.position.y+6f);
    }

    // Для того чтобы выбрать и подсветить кпопку в UI элементе и EventSystem
    public void OnPointerUp(PointerEventData eventData)
    {
        transform.position = new Vector2(transform.position.x, transform.position.y-6f);
    }
}
