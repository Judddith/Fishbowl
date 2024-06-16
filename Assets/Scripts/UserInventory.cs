using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInventory : MonoBehaviour
{

    public List<IInventoryItem> inventoryItems = new List<IInventoryItem>();

    public event EventHandler<InventoryEventArgs> AddedToInventory;

    public void AddToInventory(IInventoryItem item)
    {
        inventoryItems.Add(item);
    }

}