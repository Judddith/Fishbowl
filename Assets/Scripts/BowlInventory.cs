using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlInventory : MonoBehaviour
{
    private List<IInventoryItem> itemsInBowl = new List<IInventoryItem>();

    public event EventHandler<InventoryEventArgs> ItemAdded;

    public void AddItem(IInventoryItem item)
    {
        if (!itemsInBowl.Contains(item)) 
        {
            Collider collider = (item as MonoBehaviour).GetComponent<Collider>();
            if (collider.enabled)
            {
                collider.enabled = false;

                itemsInBowl.Add(item);

                item.OnPlacement();

                ItemAdded?.Invoke(this, new InventoryEventArgs(item));
            }
        }
    }
}
