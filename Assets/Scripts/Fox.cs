using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour, IInventoryItem
{
    GameObject ObjectFox;

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
        
        ObjectFox.SetActive(true);
    }

    
    GameObject UserInv;

    void Start()
    {
        UserInv = GameObject.Find("UserInventory");
        UserInv.GetComponent<UserInventory>().AddToInventory(this);

        ObjectFox = GameObject.Find("Fox");
    }

}
