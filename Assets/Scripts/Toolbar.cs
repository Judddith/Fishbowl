using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toolbar : MonoBehaviour
{
    public UserInventory UserInventory;
    
    
    // Start is called before the first frame update
    void Start()
    {
        UserInventory.AddedToInventory += Item_Added;

    }

    private void Item_Added(object sender, InventoryEventArgs e)
    {
        //Checking for an empty panel to add the asset to the Inventory
        Transform inventoryPanel = transform.Find("Toolbar");
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
