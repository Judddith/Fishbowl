using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

//Drag and drop handler
public class DraggableItem : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public Transform parentAfterDrag;
    public Image image;
    public GameObject draggedObject;
    public GameObject bowl;
    public Camera playerCamera;
    public List<Item> itemsInBowl;
    


    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling(); //display the dragged object over other objects
        image.raycastTarget = false; //makes object invisible for mouse input, object under mouse would be image otherwise
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End drag");

        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast (ray, out hit)) {
            Debug.Log("erste IF");
            if (hit.collider.CompareTag("bowl")) {
                Debug.Log("hit bowl!");
                draggedObject.SetActive(true);
                bowl.GetComponent<ItemsInBowl>().ItemsSpawned.Add(draggedObject); //adds active dragged item to item list

                //image.raycastTarget = false;

                // CanvasRenderer canvasRenderer;
                // canvasRenderer = draggedObject.GetComponent<CanvasRenderer>();
                // canvasRenderer.m_RaycastTarget = false;
            }
        }

        transform.SetParent(parentAfterDrag); //reset hierarchy after dropping
        image.raycastTarget = true; //makes object interactive with mouse again
        
        if (bowl.GetComponent<ItemsInBowl>().ItemsSpawned.Contains(draggedObject)) {
            image.raycastTarget = false;
        }
    }

}
