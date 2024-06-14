using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IDragHandler, IEndDragHandler
{
    Vector3 mousePosition;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }

    private Vector3 GetMousePosition() 
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }
    
    /*private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePosition();
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }
    */
}
