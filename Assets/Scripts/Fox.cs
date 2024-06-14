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
        //Not yet important
        //gameObject.SetActive(true);
    }

}
