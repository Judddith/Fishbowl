using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlInventory : MonoBehaviour
{
    GameObject Bowl;

    public Collider DomeCollider;

    private List<IInventoryItem> itemsInBowl = new List<IInventoryItem>();

    public event EventHandler<InventoryEventArgs> ItemAdded;

    void Start()
    {
        Bowl = GameObject.Find("GlassDome");
        DomeCollider = Bowl.GetComponent<Collider>();
    }

    public void AddItem(IInventoryItem item)
    {
        if (!itemsInBowl.Contains(item)) 
        {
            //Function to add an Item to the Bowl inventory
            //Collider collider = (item as MonoBehaviour).GetComponent<Collider>();
            RaycastHit hit = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (DomeCollider.Raycast(ray, out hit, 1000))
            {

                itemsInBowl.Add(item);

                item.OnPlacement();

                ItemAdded?.Invoke(this, new InventoryEventArgs(item));
                
            }
        }
    }
}
