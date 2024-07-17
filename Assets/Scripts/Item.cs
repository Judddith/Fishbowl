using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Standardaufbau aller vom Nutzer platzierbaren Objekte
public class Item {

    string Name { get; }
    Sprite Image { get; }
    GameObject ItemPrefab;

    //ItemPrefab = Name + "_Prefab"; 

    void PlaceItem(List<Item> items) {
        if (GameObject.Find(ItemPrefab) = null)
        {
            Instantiate(ItemPrefab, position, Quaternion.identity);
            items.Add(Item);
        }
        
    }
    
}


