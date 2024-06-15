using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Standardaufbau aller vom Nutzer platzierbaren Objekte
//Siehe Fox.cs für genaueres
public interface IInventoryItem {

    string Name { get; }

    Sprite Image { get; }

    void OnPlacement();
}

//Eventaufbau, zur Übermittlung eines platzierten Objektes
public class InventoryEventArgs : EventArgs
{
    public InventoryEventArgs(IInventoryItem item)
    {
        Item = item;
    }

    public IInventoryItem Item;
}

