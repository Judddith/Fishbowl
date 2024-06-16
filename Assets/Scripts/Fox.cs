using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour, IInventoryItem
{

    public string Name 
    { 
        get
        {
            return "Fox";
        }
    }

    public Sprite _Image = null;

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public void OnPlacement()
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, 1000))
        {
            Debug.Log("Item has been placed");
        }
    }

}
