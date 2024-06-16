using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInventory : MonoBehaviour
{

    private List<IInventoryItem> inventoryItems = new List<IInventoryItem>();

    public event EventHandler<InventoryEventArgs> AddedToInventory;

    public void AddItem(IInventoryItem item)
    {
        if (!inventoryItems.Contains(item))
        {

            inventoryItems.Add(item);

            AddedToInventory?.Invoke(this, new InventoryEventArgs(item));
        }
    }
}