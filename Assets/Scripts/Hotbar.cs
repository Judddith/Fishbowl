using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    public BowlInventory BowlInventory;

    // Start is called before the first frame update
    void Start()
    {
        BowlInventory.ItemAdded += Inventory_ItemAdded;
    }

    private void Inventory_ItemAdded(object sender, InventoryEventArgs e)
    {
        //Checking for an empty panel to add the asset to the Bowl Inventory
        Transform inventoryPanel = transform.Find("Hotbar");
        foreach(Transform slot in inventoryPanel)
        {
            //Accurately setting the Sprite for the visual representation
            Image image = slot.GetChild(0).GetComponent<Image>();
        

            //An empty slot was found
            if(!image.enabled)
            {
                image.enabled = true;
                image.sprite = e.Item.Image;

                break;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
