using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using System;
using Unity.VisualScripting;

//Drag and drop handler
public class DraggableItem : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public Transform parentAfterDrag;
    public Image image;
    public GameObject draggedObject;
    public GameObject bowl;
    public Camera playerCamera;
    public List<Item> itemsInBowl;
    public Transform parentButton;

    public void Start() {
        image = this.GetComponent<Image>();
        
        bowl = GameObject.Find("GlassDome");
        playerCamera = GameObject.Find("MainCameraOutside").GetComponent<Camera>();

        //Debug.Log($"{image}, {bowl}, {playerCamera}, {draggedObject}");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentButton = transform.parent;
        Debug.Log("Begin drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling(); //display the dragged object over other objects
        image.raycastTarget = false; //makes object invisible for mouse input, object under mouse would be image otherwise
        bowl.GetComponent<CameraRotator>().enabled = false; //disable camera movement while dragging
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End drag");

        bowl.GetComponent<CameraRotator>().enabled = true; //enable camera movement after dragging
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("erste IF");
            if (hit.collider.CompareTag("bowl"))
            {
                Debug.Log("hit bowl!");
                draggedObject.SetActive(true);
                bowl.GetComponent<ItemsInBowl>().ItemsSpawned.Add(draggedObject); //adds active dragged item to item list
            }
        }

        transform.SetParent(parentAfterDrag); //reset hierarchy after dropping
        image.raycastTarget = true; //makes object interactive with mouse again

        if (bowl.GetComponent<ItemsInBowl>().ItemsSpawned.Contains(draggedObject))
        {
            image.raycastTarget = false;
            //parentButton.GetComponent<Button>().transform;
        }
    }

}
